using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Weather_App.Weather.Info
{
    public class AstronomyInfo
    {

        public class Rootobject
        {
            public Location location { get; set; }
            public Astronomy astronomy { get; set; }
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

        public class Astronomy
        {
            public Astro astro { get; set; }
        }

        public class Astro
        {
            public string sunrise { get; set; }
            public string sunset { get; set; }
            public string moonrise { get; set; }
            public string moonset { get; set; }
            public string moon_phase { get; set; }
            public string moon_illumination { get; set; }
            public int is_moon_up { get; set; }
            public int is_sun_up { get; set; }
        }

    }
}
