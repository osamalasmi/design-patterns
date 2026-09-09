using ObserverPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern.Displays
{
    internal class ForecastDisplay : Observer, DisplayElement
    {
        private float temperature;
        private float humidity;
        private float pressure;
        private Subject weatherData;
        public ForecastDisplay(Subject weatherData)
        {
            // Set the field and register itself with the weatherdata subject
            this.weatherData = weatherData;
            weatherData.RegisterObserver(this);
        }
        public void Update(float temp, float humidity, float pressure)
        {
            // Set the correct fields with the relevant parameters
            this.temperature = temp;
            this.humidity = humidity;
            this.pressure = pressure;
            Display();
        }

        public void Display()
        {
            // Print a forecast message based on the current temperature and humidity
            if (pressure > 30.2)
            {
                Console.WriteLine($"Forecast: mooi weer komt er aan!");
            }
            else
            {
                Console.WriteLine($"Forecast: trek je paraplu's uit de kast");
            }
        }
    }
}
