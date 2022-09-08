using System;
using System.Collections.Generic;
using System.Text;

namespace Weather_console.Repository
{
    public class Weather
    {
        public WeatherRequest Request { get; set; }
        public WeatherLocation Location { get; set; }
        public WeatherCurrent Current { get; set; }
    }
}
