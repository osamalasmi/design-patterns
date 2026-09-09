using ObserverPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    internal class WeatherData : Subject
    {
        private List<Observer> observers;
        private float temperature;
        private float humidity;
        private float pressure;

        public WeatherData()
        {
            observers = new List<Observer>();
        }
        // instance variables
        public void NotifyObservers()
        {
            // Loop through the observers and call Update() with the appropriate fields
            foreach (var o in observers)
            {
                o.Update(temperature, humidity, pressure);
            }

        }

        public void RegisterObserver(Observer o)
        {
            // Check if observer is not already subscribed, if not then add to the list of observers
            if (!observers.Contains(o))
            {
                observers.Add(o);
            }
            else
            {
                Console.WriteLine("Observer is already subscribed");
            }
        }

        public void RemoveObserver(Observer o)
        {
            // Check if observer is subscribed, if they are then remove from the list of observers
            if (observers.Contains(o))
            {
                observers.Remove(o);
            }
            else
            {
                Console.WriteLine("You are trying to remove an observer that does not exist");
            }
           
        }

        public void MeasurementChanged()
        {
            NotifyObservers();
        }

        public void SetMeasurements(float temperature, float humidity, float pressure)
        {
            this.temperature = temperature;
            this.humidity = humidity;
            this.pressure = pressure;
            MeasurementChanged();
        }
    }
}
