using Microsoft.Extensions.DependencyInjection;

namespace MediatrUsingExample.Repositories.InMemory;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddInMemoryRepositories(this IServiceCollection services)
    {
        services.AddScoped<IWeatherForecastRepository, WeatherForecastRepository>();

        return services;
    }
}