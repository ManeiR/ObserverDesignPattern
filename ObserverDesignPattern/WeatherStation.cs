using System;
using System.Collections.Generic;

namespace ObserverDesignPattern
{
    public class WeatherStation : ISubject
    {
        private List<IObserver> _observers;

        private float _temperature;

        public float Temperature 
        {
            get { return _temperature; }
            set
            {
                _temperature = value;
            }
        }

        public WeatherStation()
        {
            _observers = new List<IObserver>();
        }

        public void Attach(IObserver observer)
        {
            _observers.Add(observer);
        }

        public void Notify()
        {
            foreach(var observer in _observers)
            {
                observer.Update(this);
            }
        }
    }
}
