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

        public async Task<IEnumerable<StarTrekStarshipDto>?> GetAllStarshipsAsync()
        {
            return await _httpClient.GetFromJsonAsync<IEnumerable<StarTrekStarshipDto>>("starship");
        }

        public async Task<StarTrekStarshipDto?> GetStarshipAsync(int id)
        {
            var response = await _httpClient.GetAsync($"starship/{id}");

            if (response.IsSuccessStatusCode)
            {
                return await response.Content.ReadFromJsonAsync<StarTrekStarshipDto>();
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

        public async Task<StarTrekStarshipDto?> AddStarshipAsync(StarTrekStarshipDto starship)
        {
            var response = await _httpClient.PostAsJsonAsync("starship", starship);
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadFromJsonAsync<StarTrekStarshipDto>();
        }

        public async Task<bool> UpdateStarshipAsync(int id, StarTrekStarshipDto starship)
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
