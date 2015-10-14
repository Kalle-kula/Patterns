using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterGenomgång
{
    public class RocketLogger
    {
        public void WriteToConsole(string message)
        {
            Console.WriteLine("Wroom: " + message);
        }
    }
}
