using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterGenomgång
{
    class RocketLoggerAdapter : ILogger
    {
        private RocketLogger logger;

        public RocketLoggerAdapter(RocketLogger logger)
        {
            this.logger = logger;
        }

        public void Log(string message)
        {
            //logger.WriteToConsole(message);
        }
    }
}
