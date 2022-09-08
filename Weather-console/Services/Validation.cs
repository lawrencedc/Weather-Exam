using System;
using Weather_console.Util;

namespace Weather_console.Services
{
    public class Validation
    {
        public static string ValidateAnswer1()
        {
            var comment = string.Empty;
            var isRaining = Query.IsRaining();

            return isRaining ? Comments.itsRaining : Comments.itsNotRaining;
        }

        public static string ValidateAnswer2()
        {
            string comment = string.Empty;
            var uvIndex = Query.GetWeatherCurrent().Uv_Index;
            if (uvIndex > Constant.MinUvIndex)
            {
                comment = String.Format(Comments.UvIndexYes, uvIndex);
            }
            else
            {
                comment = String.Format(Comments.UvIndexNo, uvIndex);
            }

            return comment;
        }

        public static string ValidateAnswer3()
        {
            string comment = string.Empty;
            var windSpeed = Query.GetWeatherCurrent().Wind_Speed;
            var isRaining = Query.IsRaining();

            if (!isRaining && windSpeed > Constant.MinWindSpeed)
            {
                comment = String.Format(Comments.KiteYes, windSpeed, Constant.MinWindSpeed);
            }
            else
            {
                comment = String.Format(Comments.KiteNo, windSpeed, Constant.MinWindSpeed);
            }

            return comment;
        }
    }
}
