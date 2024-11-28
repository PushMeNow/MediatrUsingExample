using MediatR;
using MediatrUsingExample.Repositories;

namespace MediatrUsingExample;

internal sealed class GetWeatherForecastsQueryHandler(IWeatherForecastRepository repository)
    : IRequestHandler<GetWeatherForecastsQuery, IReadOnlyCollection<WeatherForecastModel>>
{
    public Task<IReadOnlyCollection<WeatherForecastModel>> Handle(GetWeatherForecastsQuery request,
                                                                  CancellationToken cancellationToken)
    {
        return repository.GetWeatherForecasts(request.Size, cancellationToken);
    }
}