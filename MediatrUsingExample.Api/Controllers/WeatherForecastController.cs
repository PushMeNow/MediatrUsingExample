using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace MediatrUsingExample.Api.Controllers;

[ApiController]
[Route("api/weather-forecasts")]
public class WeatherForecastController(IMediator mediator) : ControllerBase
{
    [HttpGet]
    public Task<IReadOnlyCollection<WeatherForecastModel>> GetSummary([FromQuery] int size = 5,
                                                                      CancellationToken cancellationToken = default)
    {
        return mediator.Send(new GetWeatherForecastsQuery(size), cancellationToken);
    }
}