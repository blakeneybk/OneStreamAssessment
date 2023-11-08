namespace OSA.Backend.Api.Two.Client
{
    public class BackendTwoApiClientService : IBackendTwoApiClientService
    {
        private readonly HttpClient _httpClient;

        // Public static readonly field for the default base address
        public static readonly Uri DefaultBaseAddress = new Uri("http://osa.backend.api.one");

        public BackendTwoApiClientService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        // Implementation of IBackendOneService interface methods...
    }
}
