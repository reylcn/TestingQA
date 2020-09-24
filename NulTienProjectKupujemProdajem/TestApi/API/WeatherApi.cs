using Newtonsoft.Json;
using RestSharp;
using TestApi.Models;

namespace TestApi.API.Request
{
    public class WeatherApi
    {
        //move to config
        private const string baseUrl = "http://api.openweathermap.org/data/2.5/weather";
        private const string city = "Belgrade";
        private const string appId = "f1e28e53cf448062928bb611aac3f7cb";

        private RestClient restClient = new RestClient(baseUrl);

        public WeatherDto GetBelgradeWeather()
        {
            RestRequest restRequest = new RestRequest($"?q={city}&appid={appId}", Method.GET);
            var restResponse = restClient.Execute<WeatherDto>(restRequest);

            var result = JsonConvert.DeserializeObject<WeatherDto>(restResponse.Content);
            return result;
            
        }
    }
}
