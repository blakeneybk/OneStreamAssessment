using Microsoft.Extensions.DependencyInjection;

namespace OSA.Backend.Api.One.Client;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddBackendOneApiClientService(this IServiceCollection services, Uri baseAddress)
    {
        // Ensure the baseAddress is not null
        if (baseAddress == null) throw new ArgumentNullException(nameof(baseAddress), "A valid base address must be provided.");

        services.AddHttpClient<IBackendOneApiClientService, BackendOneApiClientService>(client =>
        {
            client.BaseAddress = baseAddress;
        });

        return services;
    }
}