using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorVideo
{
    class StockMediator : IMediator
    {
        private List<Colleague> colleagues;
        private IList<StockOffer> stockBuyOffers;
        private IList<StockOffer> stockSellOffers;

        private int colleagueCodes = 0;

        public StockMediator()
        {
            colleagues = new List<Colleague>();
            stockBuyOffers = new List<StockOffer>();
            stockSellOffers = new List<StockOffer>();
        }

        
        public void addColleague(Colleague newColleague)
        {
            colleagues.Add(newColleague);
            colleagueCodes++;
            newColleague.setCollCode(colleagueCodes);
        }

        public void saleOffer(string stock, int shares, int collCode)
        {
            bool stockSold = false;
            stockSellOffers.Add(new StockOffer(shares, stock, collCode));
            foreach (StockOffer offer in stockBuyOffers)
            {
                if ((offer.getStockSymbol() == stock) && (offer.getStockShares() == shares))
                {
                    Console.WriteLine("{0} shares of {1} sold to colleague {2}", shares, stock, offer.getCollCode());

                    stockBuyOffers.Remove(offer);
                    stockSold = true;
                }
                if (stockSold)
                {
                    break;
                }

                if (!stockSold)
                {
                    Console.WriteLine("{0} share of {1} added to inventory", shares, stock);

                    StockOffer newOffering = new StockOffer(shares, stock, collCode);

                    stockSellOffers.Add(newOffering);
                }
            }
        }

        public void buyOffer(string stock, int shares, int collCode)
        {
            bool stockBought = false;

            foreach (StockOffer offer in stockSellOffers)
            {
                if ((offer.getStockSymbol() == stock) && (offer.getStockShares() == shares))
                {
                    Console.WriteLine("{0} shares of {1} bought by colleague {2}", shares, stock, offer.getCollCode());

                    stockSellOffers.Remove(offer);
                    stockBought = true;
                }
                if (stockBought)
                {
                    break;
                }

                if (!stockBought)
                {
                    Console.WriteLine("{0} share of {1} added to inventory", shares, stock);

                    StockOffer newOffering = new StockOffer(shares, stock, collCode);

                    stockBuyOffers.Add(newOffering);
                }
            }
        } 
        public void getStockOfferings()
        {
            Console.WriteLine("\n Stocks for sale: ");

            foreach (StockOffer offer in stockSellOffers)
            {
                Console.WriteLine("{0} of {1}", offer.getStockShares(), offer.getStockSymbol());
            }

            Console.WriteLine("\n Stocks buy offers: ");

            foreach (StockOffer offer in stockBuyOffers)
            {
                Console.WriteLine("{0} of {1}", offer.getStockShares(), offer.getStockSymbol());
            }
        }       
    }
}
