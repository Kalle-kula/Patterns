using ObserverVideo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    public class StockGrabber : ISubject
    {
        private List<IObserver> observers;

        private double ibmPrice;
        private double aaplPrice;
        private double gooPrice;

        public StockGrabber()
        {
            observers = new List<IObserver>();
        }

        public void register(IObserver newObserver)
        {
            observers.Add(newObserver);
        }

        public void unregister(IObserver deleteObserver)
        {
            int observerIndex = observers.IndexOf(deleteObserver);
            Console.WriteLine("Observer " + (observerIndex+1) + " deleted");
            observers.RemoveAt(observerIndex);
        }

        public void notifyObserver()
        {
            foreach (IObserver observer in observers)
            {
                observer.Update(ibmPrice, aaplPrice, gooPrice);
            }
        }         
   
        public void setIBMPrice(double newIBMPrice)
        {
            this.ibmPrice = newIBMPrice;
            notifyObserver();
        }

        public void setAAPLPrice(double newAAPLPrice)
        {
            this.aaplPrice = newAAPLPrice;
            notifyObserver();
        }

        public void setGOOPrice(double newGOOPrice)
        {
            this.gooPrice = newGOOPrice;
            notifyObserver();
        }       

    }
}
