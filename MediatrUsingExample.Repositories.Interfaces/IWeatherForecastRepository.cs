namespace MediatrUsingExample.Repositories;

public interface IWeatherForecastRepository
{
    Task<IReadOnlyCollection<WeatherForecastModel>> GetWeatherForecasts(int size,
                                                                        CancellationToken cancellationToken = default);
}