using MediatR;

namespace MediatrUsingExample;

public sealed record GetWeatherForecastsQuery(int Size = 5) : IRequest<IReadOnlyCollection<WeatherForecastModel>>;