using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyweightGenomgång
{
    class Program
    {
        static void Main(string[] args)
        {
            CakeFlyweightFactory factory = new CakeFlyweightFactory();
            Cake cake1 = factory.MakeOrGetCake(45);
            Cake cake2 = factory.MakeOrGetCake(45);
            Console.WriteLine(cake1.GetHashCode()); //kollar "Id:et" på instansen
            Console.WriteLine(cake2.GetHashCode());
            Console.ReadLine();
        }
    }
}
