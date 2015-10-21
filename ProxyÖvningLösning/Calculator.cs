using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyÖvningLösning
{
    class Calculator : ICalculator
    {
        private int result;

        public int Result
        {
            get
            {
                return result;
            }
         }

        public void Add(int i1, int i2)
        {
            this.result = i1 + i2;
        }
    }
}
