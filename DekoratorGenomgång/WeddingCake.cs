using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DekoratorGenomgång
{
    public class WeddingCake : ICake
    {
        private decimal cost;

            public WeddingCake(decimal cost)
        {
            this.cost = cost;
        }

        public decimal Cost
        {
            get { return cost; }
            set { cost = value; }
        }
    }
}
