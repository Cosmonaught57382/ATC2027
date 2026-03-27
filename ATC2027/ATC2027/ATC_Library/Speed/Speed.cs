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

        public Speed(float knots)
        {
            this.knots = knots;
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

        public ISpeed Increment(float val = 1)
        {
            return new Speed(knots + val);
        }

        public ISpeed Decrement(float val = 1) { 
            return new Speed(knots - val);
        }
    }
}
