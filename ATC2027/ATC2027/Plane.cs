using ATC2027.ATC_Library;
using ATC2027.ATC_Library.Clearance;
using ATC2027.ATC_Library.CollectionRing;
using ATC2027.ATC_Library.Heading;
using ATC2027.Controls;
using ATC2027.DataStructures;
using ATC2027.ExtensionClasses;
using ATC2027.Forms;
using ATC2027.Interfaces;
using ATC2027.Library.Altitude;
using ATC2027.Library.FlightNumber;
using ATC2027.Library.Speed;
using Microsoft.VisualBasic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;

namespace ATC2027
{
    public class Plane : MoveableItem, IHasDevModeDrawableString
    {

        Vector2 location;
        IClearance clearance;

        bool isSelected;

        Color selectedTextDrawColor;
        Color normalTextDrawColor;
        
        #region graphical components
        Square head;
        Line tail;
        #endregion


        TimeSpan lastAppendageToPreviousLocations = TimeSpan.Zero + TimeSpan.FromMicroseconds(1);
        TimeSpan previousLastAppendageToPreviousLocations = TimeSpan.Zero;
        
        MonogameTimeFilteredList<Vector2> previousLocations;
        private static TimeSpan appendToPreviousLocationsFrequency = TimeSpan.FromMilliseconds(250); //the smaller this is the sooner the line drawing updates

        #region textual components
        public string getTopLine() => this.altitude.GetAltitudeAsFlightLevel() + " " + VerticalMovement.ToString(VerticalMovement.VerticalMovementEnum.unknown) + " " + this.speed.ToKnots().ToString();
        public string getBottomLine() => flightNumber.ToString();
        #endregion

        //Altitude
        IAltitude altitude;
        VerticalMovement.VerticalMovementEnum verticalMovement;
        //Speed
        ISpeed speed;
        //FlightNumber
        FlightNumber flightNumber;
        //Heading
        IHeading heading;
        #region vertical movement enum and method

        enum FlightRelationToAirfield
        {
            Arrival,Departure,FlyOver,Unknown
        }
        #endregion
        public Plane(FlightNumber flNo, IHeading heading, IAltitude altitude, ISpeed speed, Vector2 location, GraphicsDevice graphicsDevice, IClearance? clearance = null, Color? selectedDrawColor = null, Color? nonSelectedDrawColor = null)
        {
            this.clearance = clearance;

            if (this.clearance == null)
            {
                this.clearance = Clearance.getEmptyClearance();
            }


            this.flightNumber = flNo;
            this.heading = heading;
            this.altitude = altitude;
            this.speed = speed;


            int sizeOfSquare = 9; //looks better when odd especially when small

            Vector2 topLeftCornerOfSquare = new Vector2(
                location.X -= sizeOfSquare / 2,
                location.Y -= sizeOfSquare / 2);

            this.selectedTextDrawColor = selectedDrawColor == null ? Color.Yellow : (Color)selectedDrawColor;
            this.normalTextDrawColor = nonSelectedDrawColor == null ? Color.White : (Color)nonSelectedDrawColor;

            head = new Square(
                topLeftCornerOfSquare, 
                sizeOfSquare, 
                Constants.getSpriteBatch().GraphicsDevice);
            tail = new Line(head.GetCentre(), head.GetCentre());

            previousLocations = new MonogameTimeFilteredList<Vector2>(TimeSpan.FromSeconds(10), [head.GetCentre()], TimeSpan.Zero);

            previousLastAppendageToPreviousLocations = lastAppendageToPreviousLocations;
        }

        public override void Draw(GameTime gameTime, SpriteBatch spriteBatch)
        {
            head.Draw(gameTime, spriteBatch);

            if (tail.ShouldBeDrawn())
                tail.Draw(gameTime, spriteBatch);
            else
                Console.WriteLine("tail is not being drawn due to the tail.ShouldBeDrawn() function returning false. This results in this message being printed");
            
            DrawTopLine(spriteBatch, ref head);
            DrawBottomLine(spriteBatch, ref head);
        }

        private void DrawBottomLine(SpriteBatch spriteBatch, ref Square planeHead)
        {
            var font = Constants.getArial_7();
            var location = planeHead.GetCentre();
            var str = getTopLine();
            location.X -= font.MeasureString(str).X / 3;
            location.Y += font.MeasureString(str).Y / 2;

            Text.StaticDraw(spriteBatch, this.getBottomLine(), font, location, Color.White);
        }

        private void DrawTopLine(SpriteBatch spriteBatch, ref Square planeHead)
        {
            var font = Constants.getArial_7();
            var location = planeHead.GetCentre();
            var topLine = getTopLine();

            var str = stringExtension.characterReplacer(topLine + topLine, ' ');


            location.X -= font.MeasureString(str).X / 2;
            location.Y -= font.MeasureString(str).Y;

            Text.StaticDraw(spriteBatch, topLine, font, location, Color.White);
        }

        public override void Update(GameTime gameTime)
        {
            //Determine draw colour of the tail
            if (isSelected)
                tail.SetColor(selectedTextDrawColor);
            else
                tail.SetColor(normalTextDrawColor);

            previousLocations.UpdateDataStructure(gameTime.TotalGameTime);

            //update start and end point of the tail only when there's been an update to previous locations
            if (previousLastAppendageToPreviousLocations != lastAppendageToPreviousLocations)
            {
                try
                {
                    tail.SetStart(previousLocations.Last());
                }
                catch (ArgumentNullException ane)
                {
                    tail.SetStart(null);
                }
                try
                {
                    tail.SetEnd(previousLocations.First());
                }
                catch (ArgumentException ane)
                {
                    tail.SetEnd(null);
                }
                    
                previousLastAppendageToPreviousLocations = lastAppendageToPreviousLocations;
            }

            //see if item should be added
            TimeSpan ts = gameTime.TotalGameTime;
            if (lastAppendageToPreviousLocations + appendToPreviousLocationsFrequency < ts)
            {
                AddPlaneLocationToPreviousLocations(ts);
                lastAppendageToPreviousLocations = ts;
            }
            
            tail.Update(gameTime);
            head.Update(gameTime);


        }

        private void AddPlaneLocationToPreviousLocations(TimeSpan ts)
        {
            previousLocations.AddItem(head.GetCentre(), ts);
        }
        
        string altitudeAsStr()
        {
           return altitude.ToString();
        }
        
        string speedAsStr()
        {
            return speed.ToKnots().ToString();
        }
        
        public string flightNoAsStr()
        {
            return flightNumber.ToString();
        }

        public string getDevModeDrawableString()
        {
            return $"tail    start  {tail.GetStartAsString()},  end  {tail.GetStartAsEnd()}\n    previousLocations.Count: {previousLocations.Count}"; 
        }

        public StatusBoardItem toStatusBoardItem()
        {
            return new StatusBoardItem(
                this.flightNoAsStr(), 
                this.altitude.ToString(), 
                this.verticalMovement, 
                this.heading, 
                this.speed, 
                ATC_Library.FlightRelationToAirfield.FlightRelationToAirfieldEnum.FlyOver);
        }

        internal void setClearance(ref IClearance clearance)
        {
            this.clearance = clearance;
        }

        internal IAircraftCollectionRingItem ToAirCraftCollectionRingItem()
        {
            throw new NotImplementedException();
        }
    }
}
