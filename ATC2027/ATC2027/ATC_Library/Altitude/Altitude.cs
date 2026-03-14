using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATC2027.Library.Altitude
{
    public class Altitude : IAltitude
    {
        private float feet;
        private bool hasChanged;
        private string memoizedToString;

        public Altitude(float feet)
        {
            this.feet = feet;
            this.hasChanged = true;
            memoizedToString = ToString();
            this.hasChanged = false;
        }

        public Altitude(string text, ComboBox cmbBoxAltitudeType)
        {
            if (cmbBoxAltitudeType.Text.ToLower() == "feet")
                this.feet = int.Parse(text);
            else
                this.feet = int.Parse(text) * 100;
        }

        public int GetAltitudeInFeet()
        {
            return (int)(feet);
        }

        public string GetAltitudeAsFlightLevel()
        {
            return (GetAltitudeInFeet() / 1000).ToString();

        }
        public string ToString() {

            if (hasChanged)
            {
                SetMemoizedToString();
                hasChanged = false;
                return ToString();
            }
            return memoizedToString;
        }

        private void SetMemoizedToString()
        {

            if (GetAltitudeInFeet() > 5000)
            {
                this.memoizedToString = "fl " + GetAltitudeAsFlightLevel().ToString();
            }
            else
            {
                string str = GetAltitudeInFeet().ToString();
                

                Stack<char> charStack = new Stack<char>(str);
                int numberOfItemsAdded = 0;
                
                for (int i = 0; i < charStack.Count; i++)
                {
                    if (numberOfItemsAdded % 3 == 0 && numberOfItemsAdded != 0)
                        this.memoizedToString += ',';

                    this.memoizedToString += charStack.Pop();
                    numberOfItemsAdded++;
                    i--;
                }

                charStack = new Stack<char>(memoizedToString);
                this.memoizedToString = "";

                foreach (var item in charStack)
                    this.memoizedToString += item;

                this.memoizedToString += " ft";
            }
                



            
        }
    }
}
