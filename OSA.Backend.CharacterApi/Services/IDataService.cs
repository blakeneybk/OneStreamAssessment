using OSA.Backend.CharacterApi.Models;

namespace OSA.Backend.CharacterApi.Services
{
    public interface IDataService
    {
        Task<IEnumerable<StarTrekCharacter>> GetAllCharactersAsync();
        Task<StarTrekCharacter> GetCharacterAsync(int id);
        Task<StarTrekCharacter> AddCharacterAsync(StarTrekCharacter character);
        Task<bool> UpdateCharacterAsync(int id, StarTrekCharacter character);
        Task<bool> DeleteCharacterAsync(int id);
    }
}
