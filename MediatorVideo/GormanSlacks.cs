using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorVideo
{
    class GormanSlacks : Colleague
    {
        public GormanSlacks(IMediator newMediator) : base(newMediator)
        {
            Console.WriteLine("Gorman Slacks has signed up with the stockexchange\n");
        }
    }
}
