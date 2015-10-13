using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResposibility
{
    public class TestCalcChain
    {
        static void Main(string[] args)
        {
            // Here I define all of the objects in the chain

            Chain chainCalc1 = new AddNumbers();
            Chain chainCalc2 = new SubtractNumbers();
            Chain chainCalc3 = new MultiNumbers();
            Chain chainCalc4 = new DivideNumbers();

            // Here I tell each object where to forward the
            // data if it can't process the request

            chainCalc1.setNextChain(chainCalc2);
            chainCalc2.setNextChain(chainCalc3);
            chainCalc3.setNextChain(chainCalc4);

            // Define the data in the Numbers Object
            // and send it to the first Object in the chain
            Console.WriteLine("What do you want to do (add, sub, mult, div): ");
            string typeOfCalc = Console.ReadLine();
            Console.WriteLine("Type in the first number: ");
            int firstNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Type in the second number: ");
            int secondNumber = int.Parse(Console.ReadLine());
            Numbers request = new Numbers(firstNumber, secondNumber, typeOfCalc);

            chainCalc1.calculate(request);
            Console.ReadLine();
        }
    }
}
