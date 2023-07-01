using System.Collections.Generic;
using TrainingAPI.Models;

namespace TrainingAPI.Services;

public interface IWeatherService
{
    IEnumerable<Weather> GetWeatherForecast(string city);
}
