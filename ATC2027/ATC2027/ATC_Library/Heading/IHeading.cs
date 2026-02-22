using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATC2027.ATC_Library.Heading
{
    public interface IHeading
    {
        public int GetHeadingInIntegerDegrees();
        public string ToString();
    }
}
