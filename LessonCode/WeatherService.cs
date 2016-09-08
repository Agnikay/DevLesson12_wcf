using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LessonCode
{
    public class WeatherService : IWeatherService
    {
        public WeatherData GetWeatherForDate(DateTime time)
        {
            Console.WriteLine("GetWeatherForDate: {0}", time);
            return new WeatherData() { Sunny = false, Temperature = 20, WindSpeed = 5 };
        }

        public string GetWeatherToday()
        {
            Console.WriteLine("GetWeatherToday");
            return "Look at window, lazy bitch";
        }

        public WeatherData GetWeatherTomorrow()
        {
            Console.WriteLine("GetWeatherTomorrow");
            return new WeatherData() { Sunny = false, Temperature = -10, WindSpeed = 20 };
        }
    }
}
