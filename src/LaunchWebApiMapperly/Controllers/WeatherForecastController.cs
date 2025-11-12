using LaunchWebApiMapperly.Service;
using Microsoft.AspNetCore.Mvc;

namespace LaunchWebApiMapperly.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetWeatherForecast")]
        public IEnumerable<WeatherForecastEuropean> Get()
        {
            var weatherForecastest = ForecastService.GetWeateher();
            var mapper = new Mapping.WeatherForecastMapper();

            List<WeatherForecastEuropean> lista2 = mapper.ToEuropean(weatherForecastest.ToList());

            // Cambio 01

            // Cambio 02

            return lista2;
        }

    }
}
