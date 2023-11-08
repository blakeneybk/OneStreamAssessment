using Microsoft.Extensions.DependencyInjection;

namespace OSA.Backend.Api.Two.Client;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddBackendTwoApiClientService(this IServiceCollection services, Uri baseAddress)
    {
        // Ensure the baseAddress is not null
        if (baseAddress == null) throw new ArgumentNullException(nameof(baseAddress), "A valid base address must be provided.");

        services.AddHttpClient<IBackendTwoApiClientService, BackendTwoApiClientService>(client =>
        {
            client.BaseAddress = baseAddress;
        });

        return services;
    }
}