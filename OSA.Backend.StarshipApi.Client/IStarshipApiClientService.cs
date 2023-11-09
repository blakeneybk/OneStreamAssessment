using OSA.Backend.StarshipApi.Client.DtoModels;

namespace OSA.Backend.StarshipApi.Client
{
    public interface IStarshipApiClientService
    {
        Task<IEnumerable<StarTrekStarshipDto>?> GetAllStarshipsAsync();
        Task<StarTrekStarshipDto?> GetStarshipAsync(int id);
        Task<StarTrekStarshipDto?> AddStarshipAsync(StarTrekStarshipDto starship);
        Task<bool> UpdateStarshipAsync(int id, StarTrekStarshipDto starship);
        Task<bool> DeleteStarshipAsync(int id);
    }
}