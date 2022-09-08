using System;
using System.Collections.Generic;
using System.Text;

namespace Weather_console.Repository
{
    public class WeatherCurrent
    {
        public string Observation_Time { get; set; }
        public string Temperature { get; set; }
        public string Weather_Code { get; set; }
        public int Wind_Speed { get; set; }
        public int Wind_Degree { get; set; }
        public string Wind_Dir { get; set; }
        public int Pressure { get; set; }
        public double Precip { get; set; }
        public int Humidity { get; set; }
        public int CloudCover { get; set; }
        public int FeelsLike { get; set; }
        public int Uv_Index { get; set; }
        public int Visibility { get; set; }
        public string Is_Day { get; set; }
        public List<string> Weather_Icons { get; set; }
        public List<string> Weather_Descriptions { get; set; }
    }
}
