using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorVideo
{
    class Program
    {
        static void Main(string[] args)
        {
            StockMediator sthlmB = new StockMediator();
            GormanSlacks broker = new GormanSlacks(sthlmB);
            JTPoorman brokerTwo = new JTPoorman(sthlmB);

            broker.saleOffer("MSTF", 100);
            broker.saleOffer("GOOG", 50);

            brokerTwo.saleOffer("MSTF", 100);
            brokerTwo.saleOffer("NRG", 10);

            broker.buyOffer("NRG", 10);

            sthlmB.getStockOfferings();
        }
    }
}
