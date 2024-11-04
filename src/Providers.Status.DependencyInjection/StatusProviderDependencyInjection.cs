using BenjaminAbt.MyDemoPlatform.Engine;
using Microsoft.Extensions.DependencyInjection;
using Providers.Status.Engine;
using Providers.Status.Engine.Queries;

namespace Providers.Status.DependencyInjection;

public static class StatusProviderDependencyInjection
{
    public static IServiceCollection AddStatusProvider(this IServiceCollection services)
    {
        // register services

        // register commands

        // register queries
        services.AddEngineQuery<GetStatusQuery, string, GetStatusQueryHandler>();

        return services;
    }
}
