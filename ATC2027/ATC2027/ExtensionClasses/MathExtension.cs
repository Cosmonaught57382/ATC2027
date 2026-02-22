using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATC2027.ExtensionClasses
{
    public static class MathExtension
    {
        public static float Map(float val, float min, float max) {
            float result = 0;
            
            result = max - min;
            result /= 100;
            result *= val;
            result += min;

            return result;
        }
        public static float Map(double val, double min, double max)
        {
            double result = 0;

            result = max - min;
            result /= 100;
            result *= val;
            result += min;

            return (float)result;
        }
    }
}
