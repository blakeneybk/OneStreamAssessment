using OSA.Backend.CharacterApi.Client.DtoModels;

namespace OSA.Backend.CharacterApi.Client
{
    public interface ICharacterApiClientService
    {
        Task<IEnumerable<StarTrekCharacterDto>?> GetAllCharactersAsync();
        Task<StarTrekCharacterDto?> GetCharacterAsync(int id);
        Task<StarTrekCharacterDto?> AddCharacterAsync(StarTrekCharacterDto character);
        Task<bool> UpdateCharacterAsync(int id, StarTrekCharacterDto character);
        Task<bool> DeleteCharacterAsync(int id);
    }
}