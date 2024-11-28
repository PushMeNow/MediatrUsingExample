using System.Reflection;
using Microsoft.Extensions.DependencyInjection;

namespace MediatrUsingExample.Client;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddMediatRClient(this IServiceCollection services)
    {
        services.AddScoped<RestClient>();
        services.AddMediatR(configuration =>
                            {
                                configuration.RegisterServicesFromAssembly(Assembly.GetExecutingAssembly());
                            });

        return services;
    }
}