using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverDesignPattern
{
    public class Program
    {
        public static void Main(string[] args)
        {
            WeatherStation weatherStation = new WeatherStation();

            NewsAgency newsAgency1 = new NewsAgency("Agency1");
            weatherStation.Attach(newsAgency1);

            NewsAgency newsAgency2 = new NewsAgency("Agency2");
            weatherStation.Attach(newsAgency2);

            weatherStation.Temperature = 21f;
            weatherStation.Temperature = 22f;
            weatherStation.Temperature = 23f;

            Console.ReadLine();
        }
    }
}
