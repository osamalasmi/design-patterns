using ObserverPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern.Displays
{
    internal class CurrentConditionDisplay : Observer, DisplayElement
    {
        private float temperature;
        private float humidity;
        private float pressure;
        private Subject weatherData;
        public CurrentConditionDisplay(Subject wd) 
        { 
            // Set the field and register itself with the weatherdata subject
            weatherData = wd;
            weatherData.RegisterObserver(this);
            
        }
        public void Update(float temp, float humid, float pres)
        {
            // Set the correct fields with the relevant parameters
            temperature = temp;
            humidity = humid;
            pressure = pres;
            Display();
        }

        public void Display()
        {
            // Print the current conditions of the weather
            Console.WriteLine($"Current conditions: {temperature}°C, {humidity}% humidity, {pressure} hPa");
        }
    }
}
