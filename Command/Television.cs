using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    public class Television : IElectronicDevice
    {
        private int volume = 0;

        public void off()
        {
            Console.WriteLine("TV is off");
        }

        public void on()
        {
            Console.WriteLine("TV is on");
        }

        public void volumeDown()
        {
            volume--;
            Console.WriteLine("TV volume is: " + volume);
        }

        public void volumeUp()
        {
            volume++;
            Console.WriteLine("TV volume is: " + volume);
        }
    }
}
