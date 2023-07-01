using TrainingAPI.Enums;
using TrainingAPI.Models;

namespace TrainingAPI.Services;

public class WeatherService : IWeatherService
{
    public IEnumerable<Weather> GetWeatherForecast(string city)
    {
        var temperature = Random.Shared.Next(-30, 50);

        return Enumerable
            .Range(1, 5)
            .Select(
                index =>
                    new Weather
                    {
                        City = city,
                        Date = DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
                        TemperatureC = temperature,
                        TemperatureF = (int)(temperature * 1.8 + 32),
                        Summary = (Summaries)Random.Shared.Next((int)Summaries.Length)
                    }
            );
    }
}
