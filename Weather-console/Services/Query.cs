using Newtonsoft.Json;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Weather_console.Repository;
using Weather_console.Util;

namespace Weather_console.Services
{
    public class Query
    {
        private static readonly HttpClient client = new HttpClient();
        private static string accessToken = "036afd9a5156850e55e1a2fe9e27c222";
        private static Weather dataWeather = new Weather();

        public static async Task ConnectWeather()
        {
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/vnd.github.v3+json"));
            client.DefaultRequestHeaders.Add("User-Agent", ".NET Foundation Repository Reporter");

            var stringTask = client.GetStringAsync("http://api.weatherstack.com/current?access_key=" + accessToken + "&query=Philippines");
            var msg = await stringTask;
            var weather = JsonConvert.DeserializeObject<Weather>(msg);
            dataWeather = weather;
        }

        public static bool IsRaining()
        {
            return dataWeather.Current.Weather_Descriptions.Any(o => o.Contains(Constant.Rain));
        }

        public static WeatherCurrent GetWeatherCurrent()
        {
            return dataWeather.Current;
        }
    }
}
