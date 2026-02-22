using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ATC2027.Library.FlightNumber
{
    public class FlightNumber(string flightNumber)
    {
        private string flightNumber = flightNumber;

        public string getFlightNumber() { return flightNumber; }

        public override string ToString()
        {
            return flightNumber;
        }
    }
}
