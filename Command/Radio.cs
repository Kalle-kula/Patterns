using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    class Radio : IElectronicDevice
    {
        private int volume = 0;
        public void off()
        {
            Console.WriteLine("Radio is off");
        }

        public void on()
        {
            Console.WriteLine("Radio is on");
        }

        public void volumeDown()
        {
            Console.WriteLine("Radio volume is: " + volume);
        }

        public void volumeUp()
        {
            Console.WriteLine("Radio volume is: " + volume);
        }
    }
}
