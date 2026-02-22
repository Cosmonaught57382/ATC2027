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

namespace ATC2027.State
{
    public class Game : AState
    {
        #region game
        IList<Plane> planeList;
        
        int indexOfSelectedPlane;
        #endregion

        #region forms
        //AlterClearance alterClearance;
        #endregion


        public override string getName => this.GetType().Name;

        public Game(ICollection<Plane>? planeList = null)
        {
            if (planeList != null)
                this.planeList = planeList.ToList();
            else
                this.planeList = [];

            indexOfSelectedPlane = -1;


            IList<StatusBoardItem> statusBoardItemList = [];

            foreach (var item in this.planeList)
                statusBoardItemList.Add(item.toStatusBoardItem());

            //alterClearance = new AlterClearance();
            //alterClearance.PopulateDataGridView(statusBoardItemList);
            //alterClearance.Show();
        }

        public override void Draw(GameTime gameTime, SpriteBatch spriteBatch)
        {
            foreach (var plane in planeList) 
                plane.Draw(gameTime, spriteBatch);

            //speedTesting.Draw(gameTime, spriteBatch);
            

            
            base.Draw(gameTime, spriteBatch);
        }

        public override void Update(GameTime gameTime)
        {
            if (planeList.Count == 0)
            {
                AddPlane(new Plane(
                    new FlightNumber("BA3441"),
                    new Heading(090f),
                    new Altitude(7539),
                    new Speed(240f),
                    new Vector2(125, 250),
                    Constants.getSpriteBatch().GraphicsDevice
                    )
                );
                indexOfSelectedPlane = 0;
            }
                
            foreach(var plane in planeList)
                plane.Update(gameTime);

            base.Update(gameTime);
        }

        public void AddPlane(Plane plane)
        {
            this.planeList.Add(plane);
            //alterClearance.PopulateDataGridView(planeList);
        }
        public void RemovePlane(Plane plane)
        {
            this.planeList.Remove(plane);
            //alterClearance.PopulateDataGridView(planeList);
        }

        public override string getDevModeDrawableString()
        {
            if (indexOfSelectedPlane < 0)
                return "selected plane is null";
            return planeList[indexOfSelectedPlane].getDevModeDrawableString();
        }
    }
}
