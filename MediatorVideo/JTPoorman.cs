using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorVideo
{
    class JTPoorman : Colleague
    {
        public JTPoorman(IMediator newMediator) : base(newMediator)
        {
            Console.WriteLine("JT Poorman has signed up with the stockexchange\n");
        }
    }
}
