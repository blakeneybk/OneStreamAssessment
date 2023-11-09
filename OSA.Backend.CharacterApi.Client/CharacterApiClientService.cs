using System.Net.Http.Json;
using OSA.Backend.CharacterApi.Client.DtoModels;

namespace OSA.Backend.CharacterApi.Client
{
    public class CharacterApiClientService : ICharacterApiClientService
    {
        private readonly HttpClient _httpClient;

        public static readonly Uri DefaultBaseAddress = new Uri("https://localhost:51001/api/");

        public CharacterApiClientService(HttpClient httpClient)
        {
            _httpClient = httpClient ?? throw new ArgumentNullException(nameof(httpClient));
        }

        public async Task<IEnumerable<StarTrekCharacterApiDto>?> GetAllCharactersAsync()
        {
            return await _httpClient.GetFromJsonAsync<IEnumerable<StarTrekCharacterApiDto>>("character");
        }

        public async Task<StarTrekCharacterApiDto?> GetCharacterAsync(int id)
        {
            var response = await _httpClient.GetAsync($"character/{id}");

            if (response.IsSuccessStatusCode)
            {
                return await response.Content.ReadFromJsonAsync<StarTrekCharacterApiDto>();
            }
            else if (response.StatusCode == System.Net.HttpStatusCode.NotFound)
            {
                return null;
            }
            else
            {
                response.EnsureSuccessStatusCode();
                return null;
            }
        }

        public async Task<StarTrekCharacterApiDto?> AddCharacterAsync(StarTrekCharacterApiDto character)
        {
            var response = await _httpClient.PostAsJsonAsync("character", character);
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadFromJsonAsync<StarTrekCharacterApiDto>();
        }

        public async Task<bool> UpdateCharacterAsync(int id, StarTrekCharacterApiDto character)
        {
            var response = await _httpClient.PutAsJsonAsync($"character/{id}", character);
            return response.IsSuccessStatusCode;
        }

        public async Task<bool> DeleteCharacterAsync(int id)
        {
            var response = await _httpClient.DeleteAsync($"character/{id}");
            return response.IsSuccessStatusCode;
        }
    }
}