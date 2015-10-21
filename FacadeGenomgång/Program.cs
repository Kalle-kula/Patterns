
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadeGenomgång
{
    class Program
    {
        static void Main(string[] args)
        {
            FlightFacade.PrepareForTakeOff("SAS1234", "West 1");
            Console.ReadLine();
        }
    }
}
