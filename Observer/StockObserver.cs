using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ObserverVideo;

namespace Observer
{
    class StockObserver : IObserver
    {
        private double ibmPrice;
        private double aaplPrice;
        private double gooPrice;

        private static int observerIDTracker = 0;

        private int observerID;

        public StockObserver(StockGrabber SG)
        {
            var stockGrabber = new StockGrabber();
            this.observerID = ++observerIDTracker;
            Console.WriteLine("New observer " + this.observerID);
            stockGrabber.register(this);

        }

        public void Update(double ibmPrice, double aaplPrice, double gooPrice)
        {
            this.ibmPrice = ibmPrice;
            this.aaplPrice = aaplPrice;
            this.gooPrice = gooPrice;
            printThePrices();
        }

        private void printThePrices()
        {
            Console.WriteLine(observerID + "\nIBM {0}: " + "\nAAPL {1}: " + "\nGOO {2}: ", ibmPrice, aaplPrice, gooPrice);
        }
    }
}
