using Newtonsoft.Json;

namespace TestApi.Models
{
    public class WeatherDto
    {
        [JsonProperty("name")]
        public string City { get; set; }

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("cod")]
        public string Code { get; set; }

        [JsonProperty("timezone")]
        public int TimeZone { get; set; }

        [JsonProperty("main")]
        public Temperture Temperture { get; set; }

        [JsonProperty("sys")]
        public Sys Sys { get; set; }


       


    }
}
