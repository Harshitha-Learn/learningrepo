using Microsoft.AspNetCore.Mvc;

namespace webapp1.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecast1Controller : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
        "FFreezingg", "BBracing", "CChilly", "CCool", "MMild", "WWarm", "BBalmy", "HHot", "SSweltering", "SScorching"
    };

        private readonly ILogger<WeatherForecast1Controller> _logger;

        public WeatherForecast1Controller(ILogger<WeatherForecast1Controller> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetWeatherForecast")]
        public IEnumerable<WeatherForecast> Get()
        {
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            })
            .ToArray();
        }
    }
}
