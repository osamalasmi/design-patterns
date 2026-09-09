using ObserverPattern.Displays;
using ObserverPattern.Interfaces;

namespace ObserverPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            WeatherData weatherData = new WeatherData();

            // Create instances of displays
            DisplayElement currentConditionDisplay = new CurrentConditionDisplay(weatherData);
            DisplayElement forecastDisplay = new ForecastDisplay(weatherData);
            DisplayElement statisticsDisplay = new StatisticsDisplay(weatherData);

            weatherData.SetMeasurements(15, 40, 20.4f);
            weatherData.SetMeasurements(30, 90, 29.2f);

            weatherData.RemoveObserver((Observer)currentConditionDisplay);

            weatherData.SetMeasurements(28, 65, 30.4f);
            weatherData.SetMeasurements(29, 70, 29.2f);

        }
    }
}