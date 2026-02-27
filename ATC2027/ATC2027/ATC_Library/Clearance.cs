using ATC2027.ATC_Library.Heading;
using ATC2027.Library.Altitude;
using ATC2027.Library.Speed;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATC2027.ATC_Library
{
    public class Clearance
    {
        IHeading? heading;
        IAltitude? altitude;
        ISpeed? speed;

        public Clearance(IHeading? heading = null, IAltitude? altitude = null, ISpeed? speed = null)
        {
            this.heading = heading;
            this.altitude = altitude;
            this.speed = speed;
        }

        public Clearance ApplyHeading(IHeading heading)
        {
            this.heading = heading;
            return this;
        }

        public Clearance ApplyAltitude(IAltitude altitude)
        {
            this.altitude = altitude;
            return this;
        }

        public Clearance ApplySpeed(ISpeed speed)
        {
            this.speed = speed;
            return this;
        }

        public Clearance getNullClearance => new Clearance(null, null, null);
    }
}
