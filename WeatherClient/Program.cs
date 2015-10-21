using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherClient
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ange en stad");
            string city = Console.ReadLine();
            Weather.WeatherServiceClient proxy = new Weather.WeatherServiceClient();
            string result = proxy.GetWeatherForCity(city);
            Console.WriteLine(result);
        }
    }
}
