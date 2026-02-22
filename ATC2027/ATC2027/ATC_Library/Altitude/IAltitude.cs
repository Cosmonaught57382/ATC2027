using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATC2027.Library.Altitude
{
    public interface IAltitude
    {
        public int GetAltitudeInFeet();
        public string GetAltitudeAsFlightLevel();
        public string ToString();
    }
}
