namespace OSA.Backend.StarshipApi.Client
{
    public class StarshipApiClientService : IStarshipApiClientService
    {
        private readonly HttpClient _httpClient;

        // Public static readonly field for the default base address
        public static readonly Uri DefaultBaseAddress = new Uri("http://osa.backend.api.one");

        public StarshipApiClientService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        // Implementation of ICharacterApiService interface methods...
    }
}
