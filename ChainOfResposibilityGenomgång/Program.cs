using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResposibilityGenomgång
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Knappa in ett tal: ");
            int tal1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Vill du använda: + - * eller /?");
            string calc = Console.ReadLine();
            Console.WriteLine("Knappa in ett tal till: ");
            int tal2 = int.Parse(Console.ReadLine());

            ICalcHandler addHandler = new CalcAddHandler();
            ICalcHandler subHandler = new CalcSubHandler();
            ICalcHandler divHandler = new CalcDivHandler();
            ICalcHandler mulHandler = new CalcMulHandler();

            addHandler.NextHandler = subHandler;
            subHandler.NextHandler = mulHandler;
            mulHandler.NextHandler = divHandler;

            addHandler.Handle(tal1, tal2, calc);
            //addHandler.Handle(tal1, tal2, calc);
            //addHandler.Handle(tal1, tal2, calc);
            //addHandler.Handle(tal1, tal2, calc);

        }
    }
}
