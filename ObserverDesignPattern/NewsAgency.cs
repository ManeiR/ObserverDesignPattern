using System;

namespace ObserverDesignPattern
{
    public class NewsAgency : IObserver
    {
        public String AgencyName { get; set; }

        public NewsAgency(String AgencyName)
        {
            this.AgencyName = AgencyName;
        }
        public void Update(ISubject subject)
        {
            //WeatherStation weatherStation = subject as WeatherStation;
            //if (weatherStation != null)
            //{

            //}
            if (subject is WeatherStation weatherStation)
            {
                Console.WriteLine(String.Format("{0} is reporting temperature as {1}", AgencyName, weatherStation.Temperature));
            }

        }
    }
}
