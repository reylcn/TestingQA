using NUnit.Framework;
using TestApi.API.Request;

namespace TestApi.APITest
{
    [TestFixture]
    public class WeatherTests
    {
        
        [Category("Belgrade Weather")]
        [Test]
        public void BelgradeWeatherReturnOk()
        {

            WeatherApi api = new WeatherApi();

            var result = api.GetBelgradeWeather();
     
            Assert.IsTrue(result.Code.Equals("200"));
        }

        [Category("Belgrade Weather")]
        [Test]
        public void BelgradeWeatherReturnMetaData()
        {

            WeatherApi api = new WeatherApi();

            var result = api.GetBelgradeWeather();

            Assert.IsTrue(result.City.Equals("Belgrade"));
            Assert.IsTrue(result.Id.Equals(792680));
        }

        [Category("Belgrade Weather")]
        [Test]
        public void BelgradeWeatherReturnTemperatureData()
        {

            WeatherApi api = new WeatherApi();

            var result = api.GetBelgradeWeather();

            Assert.IsNotEmpty(result.Temperture.Tempreture.ToString());
            Assert.IsNotEmpty(result.Temperture.TemperatureMin.ToString());
            Assert.IsNotEmpty(result.Temperture.TemperatureMax.ToString());
            Assert.IsNotEmpty(result.Temperture.Pressure.ToString());
            Assert.IsNotEmpty(result.Temperture.FeelsLike.ToString());
        }

        [Category("Belgrade Weather")]
        [Test]
        public void BelgradeWeatherReturnSysData()
        {

            WeatherApi api = new WeatherApi();

            var result = api.GetBelgradeWeather();

            Assert.IsTrue(result.Sys.Country.Equals("RS"));
            Assert.IsNotEmpty(result.Sys.Sunrise.ToString());
            Assert.IsNotEmpty(result.Sys.Sunset.ToString());
        }
    }
}
