namespace OSA.Backend.CharacterApi.Client
{
    public class CharacterApiClientService : ICharacterApiClientService
    {
        private readonly HttpClient _httpClient;

        // Public static readonly field for the default base address
        public static readonly Uri DefaultBaseAddress = new Uri("http://osa.backend.api.one");

        public CharacterApiClientService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        // Implementation of ICharacterApiService interface methods...
    }
}
