namespace MediatrUsingExample.Repositories.InMemory;

internal sealed class WeatherForecastRepository : IWeatherForecastRepository
{
    private static readonly string[] Summaries =
    [
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    ];

    public Task<IReadOnlyCollection<WeatherForecastModel>> GetWeatherForecasts(int size,
                                                                               CancellationToken cancellationToken =
                                                                                   default)
    {
        var weatherForecastModels = Enumerable.Range(1, size)
                                              .Select(index =>
                                                          new WeatherForecastModel(
                                                              DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
                                                              Random.Shared.Next(-20, 55),
                                                              Summaries[Random.Shared.Next(Summaries.Length)]
                                                          ))
                                              .ToArray();

        return Task.FromResult<IReadOnlyCollection<WeatherForecastModel>>(weatherForecastModels);
    }
}