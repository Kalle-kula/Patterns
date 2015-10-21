using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyGenomgång
{
    class QuedLoggerProxy : ILogger
    {
        private ILogger realLogger;
        private IList<string> messages = new List<string>();

        public QuedLoggerProxy(ILogger realLogger)
        {
            this.realLogger = realLogger;
        }
        public void Log(string message)
        {
            messages.Add(message);
        }
        public void Flush()
        {
            foreach (var message in messages)
            {
                this.realLogger.Log(message);
            }
        }
    }
}
