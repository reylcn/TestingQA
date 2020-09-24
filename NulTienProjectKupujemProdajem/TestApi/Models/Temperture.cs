using Newtonsoft.Json;

namespace TestApi.Models
{
    public class Temperture
    {
        [JsonProperty("temp")]
        public double Tempreture { get; set; }

        [JsonProperty("temp_min")]
        public double TemperatureMin { get; set; }

        [JsonProperty("temp_max")]
        public double TemperatureMax { get; set; }

        [JsonProperty("feels_like")]
        public double FeelsLike { get; set; }

        [JsonProperty("pressure")]
        public double Pressure { get; set; }
    }
}
