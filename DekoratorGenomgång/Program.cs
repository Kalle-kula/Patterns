using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DekoratorGenomgång
{
    class Program
    {
        

        static void Main(string[] args)
        {
            ICake cake = new WeddingCake(1000M);
            cake = new MeringuesOptions(cake);
            cake = new MMsOption(cake);
            Console.WriteLine("Cost for cake is {0}", cake.Cost);
            Console.ReadLine();
        }
    }
}
