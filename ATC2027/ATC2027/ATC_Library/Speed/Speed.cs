using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATC2027.Library.Speed
{
    public class Speed : ISpeed
    {
        private float knots;
        private string text;

        public Speed(float knots)
        {
            this.knots = knots;
        }

        public Speed(string text)
        {
            this.text = text;
        }

        public int ToKnots()
        {
            return (int)knots;
        }

        public ISpeed FromKnots()
        {
            return new Speed(knots);
        }

        public string ToString()
        {
            return ToKnots().ToString() + "kt";
        }

        public float ToKnotsFloat()
        {
            return (float)knots;
        }
    }
}
