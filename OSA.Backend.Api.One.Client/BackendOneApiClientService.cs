namespace OSA.Backend.Api.One.Client
{
    public class BackendOneApiClientService : IBackendOneApiClientService
    {
        private readonly HttpClient _httpClient;

        // Public static readonly field for the default base address
        public static readonly Uri DefaultBaseAddress = new Uri("http://osa.backend.api.one");

        public BackendOneApiClientService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        // Implementation of IBackendOneService interface methods...
    }
}
