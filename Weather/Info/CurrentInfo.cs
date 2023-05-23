using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Weather_App.Weather.Info
{
    public class CurrentInfo
    {
        public class Rootobject
        {
            public Location location { get; set; }
            public Current current { get; set; }
        }

        public class Location
        {
            public string name { get; set; }
            public string region { get; set; }
            public string country { get; set; }
            public float lat { get; set; }
            public float lon { get; set; }
            public string tz_id { get; set; }
            public int localtime_epoch { get; set; }
            public string localtime { get; set; }
        }

        public class Current
        {
            public string last_updated { get; set; }
            public float temp_c { get; set; }
            public Condition condition { get; set; }
            public float wind_kph { get; set; }
            public string wind_dir { get; set; }
            public float pressure_mb { get; set; }
            public float pressure_in { get; set; }
            public float precip_mm { get; set; }
            public int humidity { get; set; }
            public int cloud { get; set; }
            public float feelslike_c { get; set; }
            public float vis_km { get; set; }
            public float uv { get; set; }
            public float gust_kph { get; set; }
        }

        public class Condition
        {
            public string text { get; set; }
            public string icon { get; set; }
            public float code { get; set; }
        }
    }
}
