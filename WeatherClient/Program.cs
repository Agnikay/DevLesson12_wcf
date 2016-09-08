using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeatherClient.WeatherService;

namespace WeatherClient
{
    class Program
    {
        static void Main(string[] args)
        {
            IWeatherService weatherService = new WeatherServiceClient();
            Console.WriteLine("Simon says: {0}", weatherService.GetWeatherToday());
            WeatherData weatherData = weatherService.GetWeatherTomorrow();
            WeatherData weatherNext = weatherService.GetWeatherForDate(DateTime.Now.AddDays(1));
            Console.ReadLine();
        }
    }
}
