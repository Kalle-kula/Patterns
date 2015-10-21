using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorVideo
{
    class StockOffer
    {
        private int stockShares = 0;
        private string stockSymbol = "";
        private int colleagueCode = 0;

        public StockOffer(int numOfShares, string stock, int collCode)
        {
            stockShares = numOfShares;
            stockSymbol = stock;
            colleagueCode = collCode;
        }

        public int getStockShares() { return stockShares; }
        public string getStockSymbol() { return stockSymbol; }
        public int getCollCode() { return colleagueCode; }
    }
}
