using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyÖvning
{
    public class Calc : ILogger
    {
        
        public int Calculate()
        {
            Console.WriteLine("Skriv in ett tal: ");
            int tal1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Skriv in ett tal till: ");
            int tal2 = int.Parse(Console.ReadLine());
            int calcResult = tal1 + tal2;
            return calcResult;

        }

        public void Log(int calcResult)
        {
            Console.WriteLine(Calculate().ToString());
            Console.WriteLine(calcResult);            
        }
    }
}
