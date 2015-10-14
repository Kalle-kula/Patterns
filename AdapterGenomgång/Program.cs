using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterGenomgång
{
    class Program
    {
        static void Main(string[] args)
        {
            //ILogger logger = new MyLogger();
            ILogger logger = new RocketLoggerAdapter(new RocketLogger());
            LogTwice(logger, "Hello World");
            Console.ReadLine();
        }

        private static void LogTwice(ILogger logger, string v)
        {
            logger.Log(v);
            logger.Log(v);
        }
    }
}
