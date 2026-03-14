using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System.Collections.Generic;
using ATC2027.Library.FlightNumber;
using ATC2027.Library.Altitude;
using ATC2027.Library.Speed;
using System.Text;
using ATC2027.Controls;
using System.Linq;
using ATC2027.Forms;
using ATC2027.ATC_Library.Heading;
using ATC2027.ATC_Library.CollectionRing;

namespace ATC2027.State
{
    public class Game : AState
    {
        #region game        
        int indexOfSelectedPlane;
        CollectionRing cr;
        #endregion

        #region forms
        AircraftCollectionRing aircraftCollectionRing;
        #endregion


        public override string getName => this.GetType().Name;

        public Game(ICollection<Plane>? planeList = null)
        {
            if (planeList == null) planeList = new List<Plane>(); 

            this.cr = new CollectionRing();

            foreach (Plane plane in planeList) { cr.AddPlane(plane); }

            if (cr.planeCollection.Count == 0)

                cr.AddPlane(new Plane(
                    new FlightNumber("BA3441"),
                    new Heading(090f),
                    new Altitude(7539),
                    new Speed(240f),
                    new Vector2(125, 250),
                    Constants.getSpriteBatch().GraphicsDevice
                    )
                );

            

            indexOfSelectedPlane = cr.planeCollection.Count-1;

            //set up the aircraft collection ring form
            IList<StatusBoardItem> statusBoardItemList = [];

            foreach (var item in cr.getAircraftCollectionRingListItemsAsList())
                statusBoardItemList.Add(item);

            
            aircraftCollectionRing = new AircraftCollectionRing(ref cr);
            aircraftCollectionRing.Show();            
        }

        public override void Draw(GameTime gameTime, SpriteBatch spriteBatch)
        {
            foreach (var plane in cr.planeCollection) 
                plane.Value.Draw(gameTime, spriteBatch);
            
            //speedTesting.Draw(gameTime, spriteBatch);
            

            
            base.Draw(gameTime, spriteBatch);
        }

        public override void Update(GameTime gameTime)
        {
            if (cr.planeCollection.Count == 0)
            {
                indexOfSelectedPlane = cr.planeCollection.Count - 1;
            }
                
            foreach(var plane in cr.planeCollection)
                plane.Value.Update(gameTime);

            base.Update(gameTime);
        }

        public void AddPlane(Plane plane)
        {
            this.cr.AddPlane(plane);
            //alterClearance.PopulateDataGridView(planeList);
        }
        public void RemovePlane(Plane plane)
        {
            this.cr.RemovePlane(plane);
        }

        public override string getDevModeDrawableString()
        {
            if (indexOfSelectedPlane < 0)
                return "selected plane is null";
            if (indexOfSelectedPlane > cr.planeCollection.Count - 1)
                return "indexOfSelectedPlane is too large";

            return cr.planeCollection.Values.ToList()[indexOfSelectedPlane].getDevModeDrawableString();
        }
    }
}
