using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    class GrabbStocks
    {
        static void Main(string[] args)
        {
            StockGrabber stockGrabber = new StockGrabber();

            StockObserver observerOne = new StockObserver(stockGrabber);
            stockGrabber.setIBMPrice(157.25);
            stockGrabber.setAAPLPrice(257.54);
            stockGrabber.setGOOPrice(358.84);

            StockObserver observerTwo = new StockObserver(stockGrabber);
            stockGrabber.setIBMPrice(158.65);
            stockGrabber.setAAPLPrice(247.67);
            stockGrabber.setGOOPrice(375.25);
        }
    }
}
