using MediatR;

namespace MediatrUsingExample.Client;

internal class WeatherForecastApiHandlers(RestClient client)
    : IRequestHandler<GetWeatherForecastsQuery, IReadOnlyCollection<WeatherForecastModel>>
{
    private const string BaseUrl = "api/weather-forecasts";

    public Task<IReadOnlyCollection<WeatherForecastModel>> Handle(GetWeatherForecastsQuery request,
                                                                  CancellationToken cancellationToken)
    {
        return client.Get<IReadOnlyCollection<WeatherForecastModel>>(BaseUrl);
    }
}