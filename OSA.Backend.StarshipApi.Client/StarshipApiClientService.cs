using System.Net.Http.Json;
using OSA.Backend.StarshipApi.Client.DtoModels;

namespace OSA.Backend.StarshipApi.Client
{
    public class StarshipApiClientService : IStarshipApiClientService
    {
        private readonly HttpClient _httpClient;

        public static readonly Uri DefaultBaseAddress = new Uri("https://localhost:51003/api/");

        public StarshipApiClientService(HttpClient httpClient)
        {
            _httpClient = httpClient ?? throw new ArgumentNullException(nameof(httpClient));
        }

        public async Task<IEnumerable<StarTrekStarshipApiDto>?> GetAllStarshipsAsync()
        {
            return await _httpClient.GetFromJsonAsync<IEnumerable<StarTrekStarshipApiDto>>("starship");
        }

        public async Task<StarTrekStarshipApiDto?> GetStarshipAsync(int id)
        {
            var response = await _httpClient.GetAsync($"starship/{id}");

            if (response.IsSuccessStatusCode)
            {
                return await response.Content.ReadFromJsonAsync<StarTrekStarshipApiDto>();
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

        public async Task<StarTrekStarshipApiDto?> AddStarshipAsync(StarTrekStarshipApiDto starship)
        {
            var response = await _httpClient.PostAsJsonAsync("starship", starship);
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadFromJsonAsync<StarTrekStarshipApiDto>();
        }

        public async Task<bool> UpdateStarshipAsync(int id, StarTrekStarshipApiDto starship)
        {
            var response = await _httpClient.PutAsJsonAsync($"starship/{id}", starship);
            return response.IsSuccessStatusCode;
        }

        public async Task<bool> DeleteStarshipAsync(int id)
        {
            var response = await _httpClient.DeleteAsync($"starship/{id}");
            return response.IsSuccessStatusCode;
        }
    }
}
