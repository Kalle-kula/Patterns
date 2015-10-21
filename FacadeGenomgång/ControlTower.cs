using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadeGenomgång
{
    class ControlTower
    {
        internal DateTime FindNextSlotForStrip(string strip)
        {
            Console.WriteLine("Finding slot for strip {0}", strip);
            DateTime departure = DateTime.Now.AddMinutes(15);
            return departure;
        }
    }
}
