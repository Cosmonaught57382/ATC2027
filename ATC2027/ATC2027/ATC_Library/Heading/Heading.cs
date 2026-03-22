using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace ATC2027.ATC_Library.Heading
{
    public class Heading : IHeading
    {
        private float v;

        public Heading(float v)
        {
            this.v = v;
        }

        public Heading(string text)
        {
            if (!float.TryParse(text, out v))
                throw new ArgumentException($"Could not convert {nameof(text)} to a float value. {nameof(text)} had the value {text}"); 
        }

        public Heading(IHeading heading)
        {
            this.v = heading.GetHeadingInFloatDegrees();
        }

        public float GetHeadingInFloatDegrees()
        {
            return v;
        }

        public int GetHeadingInIntegerDegrees()
        {
            return (int)v;

        }

        public override string ToString() { 
            string str = v.ToString();
            str = str.Trim().Split(".")[0];
            
            while (str.Length < 3) 
                str = "0" + str;
            
            return str;
        }

        internal float GetHeadingInFloatRadians()
        {
            return MathHelper.ToRadians(v-90);
        }

        public static Heading operator ++(Heading operand)
        {
            float currentHeadingAsFloat = operand.GetHeadingInFloatDegrees();
            currentHeadingAsFloat += 1;
            currentHeadingAsFloat %= 360;
            return new Heading(currentHeadingAsFloat);
        }
        public static Heading operator --(Heading operand)
        {
            float currentHeadingAsFloat = operand.GetHeadingInFloatDegrees();
            currentHeadingAsFloat -= 1;
            
            while (currentHeadingAsFloat < 0)
            {
                currentHeadingAsFloat += 360;
            }

            return new Heading(currentHeadingAsFloat);
        }
    }
}
