using System.Reflection;
using Microsoft.Extensions.DependencyInjection;

namespace MediatrUsingExample;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddApplicationServices(this IServiceCollection services)
    {
        services.AddMediatR(configuration =>
                            {
                                configuration.RegisterServicesFromAssembly(Assembly.GetExecutingAssembly());
                            });
        return services;
    }
}