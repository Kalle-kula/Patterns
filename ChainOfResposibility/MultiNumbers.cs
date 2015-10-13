using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResposibility
{
    class MultiNumbers : Chain
    {
        private Chain nextInChain;

        public void setNextChain(Chain nextChain)
        {
            nextInChain = nextChain;
        }

        public void calculate(Numbers request)
        {
            if (request.getCalcWanted() == "mult")
            {
                Console.WriteLine(request.getNumber1() + " * " + request.getNumber2() + " = " + (request.getNumber1() * request.getNumber2()));
            }
            else
            {
                nextInChain.calculate(request);
            }
        }
    }
}
