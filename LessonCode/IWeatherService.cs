using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace LessonCode
{
    [ServiceContract]
    public interface IWeatherService
    {
        [OperationContract]
        string GetWeatherToday();

        [OperationContract]
        WeatherData GetWeatherTomorrow();

        [OperationContract]
        WeatherData GetWeatherForDate(DateTime time);
    }
}
