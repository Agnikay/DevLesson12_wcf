using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace LessonCode
{
    [DataContract]
    public class WeatherData
    {
        [DataMember]
        public int Temperature { set; get; }

        [DataMember]
        public int WindSpeed { set; get; }

        [DataMember]
        public bool Sunny { set; get; }
    }
}
