using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATC2027.ATC_Library.Heading
{
    public class Heading : IHeading
    {
        private float v;
        private string text;

        public Heading(float v)
        {
            this.v = v;
        }

        public Heading(string text)
        {
            this.text = text;
        }

        public int GetHeadingInIntegerDegrees()
        {
            throw new NotImplementedException();
        }

        public override string ToString() { 
            string str = v.ToString();
            str = str.Trim().Split(".")[0];
            
            while (str.Length < 3) 
                str = "0" + str;
            
            return str;
        }

    }
}
