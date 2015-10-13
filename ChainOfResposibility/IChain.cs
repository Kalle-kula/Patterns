using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResposibility
{
    // The chain of responsibility pattern has a 
    // group of objects that are expected to between
    // them be able to solve a problem. 
    // If the first Object can't solve it, it passes
    // the data to the next Object in the chain
    public interface IChain
    {
            // Defines the next Object to receive the data
            // if this Object can't process it

             void setNextChain(IChain nextChain);

            // Either solves the problem or passes the data
            // to the next Object in the chain

             void calculate(Numbers request);        
    }
}
