using TrainingAPI.Enums;

namespace TrainingAPI.Models;

public class Weather
{
    public string City { get; set; } = string.Empty;
    public DateOnly Date { get; set; }
    public int TemperatureC { get; set; }
    public int TemperatureF { get; set; }
    public Summaries Summary { get; set; }
}
