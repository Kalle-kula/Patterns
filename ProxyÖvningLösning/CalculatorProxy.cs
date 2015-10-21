using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyÖvningLösning
{
    class CalculatorProxy : ICalculator
    {
        private ICalculator calc;
        public CalculatorProxy(ICalculator calc)
        {
            this.calc = calc;
        }
        public int Result
        {
            get
            {
                return this.calc.Result;
            }
        }

        public void Add(int i1, int i2)
        {
            this.calc.Add(i1, i2);
            File.AppendAllText("calc.log", string.Format("{0}+{1}={2}", i1, i2, this.calc.Result));
        }
    }
}
