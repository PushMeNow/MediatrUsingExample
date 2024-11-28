namespace MediatrUsingExample;

public sealed record WeatherForecastModel(DateOnly Date, int TemperatureC, string? Summary)
{
    public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);
}