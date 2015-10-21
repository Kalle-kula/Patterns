using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadeGenomgång
{
    class Flight
    {
        public AirPlane plane;

        public Flight(AirPlane plane)
        {
            this.plane = plane;
        }
        internal void DepartureAtTime(DateTime time)
        {
            Console.WriteLine("Plane {0} departed at {1}", plane, time);
        }
    }
}
