using OSA.Backend.StarshipApi.Models;

namespace OSA.Backend.StarshipApi.Services
{
    public interface IDataService
    {
        Task<IEnumerable<StarTrekStarship>> GetAllStarshipsAsync();
        Task<StarTrekStarship> GetStarshipAsync(int id);
        Task<StarTrekStarship> AddStarshipAsync(StarTrekStarship starship);
        Task<bool> UpdateStarshipAsync(int id, StarTrekStarship starship);
        Task<bool> DeleteStarshipAsync(int id);
    }
}
