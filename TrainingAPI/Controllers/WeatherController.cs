using Microsoft.AspNetCore.Mvc;
using TrainingAPI.Models;
using TrainingAPI.Services;

namespace TrainingAPI.Controllers;

[Route("api/[controller]")]
[ApiController]
public class WeatherController : ControllerBase
{
    private readonly IWeatherService _weatherService;
    private readonly ILogger<WeatherController> _logger;

    public WeatherController(IWeatherService weatherService, ILogger<WeatherController> logger)
    {
        _weatherService = weatherService;
        _logger = logger;
    }

    [HttpGet]
    public IEnumerable<Weather> Get(string city)
    {
        try
        {
            var result = _weatherService.GetWeatherForecast(city);
            _logger.LogInformation("Getting data about weather in {city}: {@result}", city, result);
            return result;
        }
        catch (Exception exception)
        {
            _logger.LogError("{@exception}", exception);
            throw;
        }
    }
}
