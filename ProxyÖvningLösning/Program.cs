using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyÖvningLösning
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator calc = new Calculator();
            CalculatorProxy proxy = new CalculatorProxy(calc);
            proxy.Add(12, 13);            
            Console.WriteLine(proxy.Result);
        }
    }
}
