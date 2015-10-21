using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadeGenomgång
{
    public static class FlightFacade
    {
        public static void PrepareForTakeOff(string flighNo, string strip)
        {
            AirPlane plane = new AirPlane();
            plane.Clean();
            ControlTower tower = new ControlTower();
            DateTime time = tower.FindNextSlotForStrip(strip);
            Flight flight = new Flight(plane);
            flight.DepartureAtTime(time);
        }
    }
}
