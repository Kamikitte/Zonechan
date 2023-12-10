using Microsoft.Extensions.DependencyInjection;
using Zonechan.Core.ZoneClient;

namespace Zonechan.Core.Infrastructure;

public static class ServiceCollectionExtension
{
    public static IServiceCollection AddZoneClient(this IServiceCollection services)
    {
        services.AddTransient<IZoneRequester, ZoneRequester>();

        return services;
    }
}