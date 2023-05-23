using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Weather_App.Weather.Info
{
    public class WeatherCodes
    {

        public class Rootobject
        {
            public Data data { get; set; }
        }

        public class Data
        {
            public Row[] row { get; set; }
        }

        public class Row
        {
            public int code { get; set; }
            public string day { get; set; }
            public string night { get; set; }
            public int icon { get; set; }
        }
    }
}
