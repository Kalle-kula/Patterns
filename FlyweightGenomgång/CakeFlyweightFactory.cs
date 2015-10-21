using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyweightGenomgång
{
    class CakeFlyweightFactory
    {
        Dictionary<int?, Cake> cakes = new Dictionary<int?, Cake>();
        public Cake MakeOrGetCake(int noOfCandles)
        {
            Cake cake = null;
            bool found = cakes.TryGetValue(noOfCandles, out cake);
            if (!found)
            {
                cake = new Cake();
                cake.NoOfCandles = noOfCandles;
                cakes.Add(noOfCandles, cake);
            }            
            return cake;
        }
    }
}
