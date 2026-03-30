using ATC2027.ATC_Library.CollectionRing;
using ATC2027.ATC_Library.Heading;
using ATC2027.ExtensionClasses;
using ATC2027.Library.Altitude;
using ATC2027.Library.FlightNumber;
using ATC2027.Library.Speed;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATC2027.Forms
{
    public partial class AddPlane : Form
    {
        #region headingOfNewPlane
        /// <summary>
        /// must be placed here even so the CalculateScoreFromSpawnPoint function can access heading
        /// </summary>
        private IHeading heading;
        private ISpeed speedForCalculatingHowLongObjectWillBeOnScreenFor = new Speed(250);
        private int bufferSize = 10;
        #endregion

        private CollectionRing cr;

        public AddPlane(ref CollectionRing cr)
        {
            this.cr = cr;

            InitializeComponent();

            this.lblErrorLabel.ForeColor = Color.Red;
            this.lblErrorLabel.TextAlign = ContentAlignment.MiddleCenter;


            this.txtBoxFlightNumber.Text = getNextFlightNumber();
            this.cmbBoxSelectSide.Items.AddRange(["top","left","bottom","right"]);

            this.txtBoxFlightNumber.TabIndex = 0;
            this.txtBoxAltitude.TabIndex = 1;
            this.txtBoxSpeed.TabIndex = 2;
            this.txtBoxHeading.TabIndex = 3;
            this.cmbBoxSelectSide.TabIndex = 4;
            this.txtBoxAcrossSide.TabIndex = 5;
            this.btnAddPlane.TabIndex = 6;
        }

        private bool ValuesAreValid(out string errorMessage)
        {
            errorMessage = "";
            if (!FlightNumber.FlightNumberIsValid(ref errorMessage, txtBoxFlightNumber.Text))
                return false;
            if (!Altitude.AltitudeIsValid(ref errorMessage, txtBoxAltitude.Text, AltitudeTypeEnum.Feet))
                return false;
            if (!Speed.SpeedIsValid(ref errorMessage, txtBoxSpeed.Text))
                return false;
            if (!Heading.HeadingIsValid(ref errorMessage, txtBoxHeading.Text))
                return false;
            if (!cmbBoxSelectSide.Items.Contains(cmbBoxSelectSide.Text))
            {
                errorMessage = "Unable to find side that was selected";
                return false;
            }
            if (!IsANumberWithInRange(txtBoxAcrossSide.Text, 0f, 100f))
            {
                errorMessage = "% across side was out of range";
                return false;
            }
            
            return true;

        }
        private bool IsANumberWithInRange(string text, float lowerLimitInclusive, float upperLimitInclusive)
        {
            float f;
            try
            {
                f = float.Parse(text);

                return lowerLimitInclusive <= f && f <= upperLimitInclusive;
            }
            catch { return false; }
        }

        private float CalculateTimeObjectWillBeOnScreenFor(Vector2 x, IHeading heading, ISpeed speed, int buffer)
        {
            //S=D/T ::: T = D/S
            var a = Constants.getHeightOfScreen + buffer - x.Y;
            var b = Constants.getWidthOfScreen + buffer - x.X;
            
            float distance = (float)Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b,2));
            return distance/speed.ToKnotsFloat();
        }

        private float CalculateScoreFromSpawnPoint(Vector2 x) {  
            return CalculateTimeObjectWillBeOnScreenFor(x,this.heading, this.speedForCalculatingHowLongObjectWillBeOnScreenFor, this.bufferSize);
        }

        private IList<string> flightNumberPrefixes = ["BA", "AF", "EJ","LH"];
        private string getNextFlightNumber()
        {
            var random = new Random();
            var stringPart = flightNumberPrefixes[random.Next(0,flightNumberPrefixes.Count)];
            var numberPart = random.Next(1000,9999);

            var candidateFlightNumber = stringPart + numberPart;

            if (cr.planeCollection.ContainsKey(candidateFlightNumber))
                return getNextFlightNumber();
            else return candidateFlightNumber;
        }

        private Vector2 CalculateSpawnLocationOfPlane(string sideName, float proportionAcrossSide)
        {
            Vector2 spawnLocation;
            sideName = sideName.ToLower();

            switch (sideName)
            {
                case "top":
                    spawnLocation = new Vector2(MathExtension.Map(proportionAcrossSide, 0, Constants.getHeightOfScreen), -20);
                    break;
                case "bottom":
                    spawnLocation = new Vector2(20 + Constants.getHeightOfScreen, MathExtension.Map(proportionAcrossSide, 0, Constants.getWidthOfScreen));
                    break;
                case "left":
                    spawnLocation = new Vector2(-20, MathExtension.Map(proportionAcrossSide, 0, Constants.getWidthOfScreen));
                    break;
                case "right":
                    spawnLocation = new Vector2(20 + Constants.getWidthOfScreen, MathExtension.Map(proportionAcrossSide, 0, Constants.getHeightOfScreen));
                    break;
                default:
                    throw new NotImplementedException("direction not yet handled");
            }

            return spawnLocation;
            
            
        }

        private void btnAddPlane_Click(object sender, EventArgs e)
        {
            
            string errorMessage;
            if (ValuesAreValid(out errorMessage))
            {
                var flNo = new FlightNumber(txtBoxFlightNumber.Text);
                var heading = new Heading(txtBoxHeading.Text);
                var altitude = new Altitude(int.Parse(txtBoxAltitude.Text));
                var speed = new Speed(int.Parse(txtBoxSpeed.Text));

                this.heading = heading;
                var location = CalculateSpawnLocationOfPlane(cmbBoxSelectSide.Text, (float.Parse(txtBoxAcrossSide.Text)));

                cr.AddPlane(new Plane(
                    flNo,
                    heading,
                    altitude,
                    speed,
                    location,
                    Constants.getSpriteBatch().GraphicsDevice));

                txtBoxFlightNumber.Text = getNextFlightNumber();
                txtBoxAltitude.Text = "";
                txtBoxHeading.Text = "";
                txtBoxSpeed.Text = "";
                cmbBoxSelectSide.Text = "";
                txtBoxAcrossSide.Text = "";
            }
            else
            {
                lblErrorLabel.Text = errorMessage;
            }
        }
    }
}
