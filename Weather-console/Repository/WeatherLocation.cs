using System;
using System.Collections.Generic;
using System.Text;

namespace Weather_console.Repository
{
    public class WeatherLocation
    {
        public string Name { get; set; }
        public string Country { get; set; }
        public string Region { get; set; }
        public string Lat { get; set; }
        public string Lon { get; set; }
        public string Timezone_Id { get; set; }
        public string LocalTime { get; set; }
        public int LocalTime_Epoch { get; set; }
        public string UTC_Offset { get; set; }
    }
}
