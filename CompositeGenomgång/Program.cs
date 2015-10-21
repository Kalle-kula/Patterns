using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositeGenomgång
{
    class Program
    {
        static void Main(string[] args)
        {
            Part window = new Part("Glasfönster", 2500M);
            Part door = new Part("Mjukstängande", 3000M);
            Console.WriteLine("Totalt att betala: {0}", window.Cost);
            Console.ReadLine();
        }
    }
}
