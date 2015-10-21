using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandGenomgång
{
    class TV
    {
        private const int MaxVolume = 20;
        private const int MinVolume = 1;
        private int Volume = 5;
        public void TurnVolumeUp()
        {
            if (Volume < MaxVolume)
            {
                Volume++;
                Console.WriteLine("TV volume up to {0}", Volume);
            }
        }

        public void TurnVolumeDown()
        {
            if (Volume > MinVolume)
            {
                Volume--;
                Console.WriteLine("TV volume down to {0}", Volume);
            }
        }
    }
}
