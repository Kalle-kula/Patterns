using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyGenomgång
{
    class Program
    {
        static void Main(string[] args)
        {
            Logger realLogger = new Logger();
            QuedLoggerProxy proxyLogger = new QuedLoggerProxy(realLogger);
            proxyLogger.Log("Namn");
            proxyLogger.Log("Namn1");
            proxyLogger.Log("Namn2");
            proxyLogger.Log("Namn3");
            Console.WriteLine("Press enter to send messages to real logger.");
            Console.ReadLine();
            proxyLogger.Flush();
        }
    }
}
