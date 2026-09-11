using ObserverPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern.Displays
{
    internal class HeatWarningDisplay : Observer, DisplayElement
    {
        private float temperature;

        private Subject weatherData;
        public HeatWarningDisplay(Subject wd)
        {
            // Set the field and register itself with the weatherdata subject
            weatherData = wd;
            weatherData.RegisterObserver(this);

        }
        public void Update(float temp, float humid, float pres)
        {
            // Set the correct fields with the relevant parameters
            temperature = temp;
            Display();
        }

        public void Display()
        {
            // Print the current conditions of the weather
            if (temperature > 30)
            {
                Console.WriteLine($"WAARSCHUWING: extreme hitte! {temperature}°C");
            }
            else
            {
                Console.WriteLine($"Geen hittewaarschuwing. {temperature}°C");
            }
            Console.WriteLine("---------------------------");
        }
    }
}
