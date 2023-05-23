using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Weather_App.Weather.Error
{

    public class WeatherError
    {
        public class Rootobject
        {
            public Error error { get; set; }
        }

        public class Error
        {
            public int code { get; set; }
            public string message { get; set; }
        }
    }
}
