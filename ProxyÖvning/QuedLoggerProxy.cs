using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyÖvning
{
    class QuedLoggerProxy
    {
        private ILogger realLogger;
        private IList<int> numbers = new List<int>();

        public QuedLoggerProxy(ILogger realLogger)
        {
            this.realLogger = realLogger;
        }
        public void Log(int calcResult)
        {
            numbers.Add(calcResult);
        }
        public void Flush()
        {
            foreach (var calcResult in numbers)
            {
                this.realLogger.Log(calcResult);
            }
        }
    }
}
