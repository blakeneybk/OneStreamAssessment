using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OSA.Backend.CharacterApi.Models;

namespace OSA.Backend.CharacterApi.Services
{
    public class MockCharacterDataService : IDataService
    {
        private readonly List<StarTrekCharacter> characters = new();
        private int nextId = 1;

        public MockCharacterDataService()
        {
            // Initialize with some characters
            characters.AddRange(new[]
            {
            // Characters from the Original Series
            new StarTrekCharacter { Id = nextId++, Name = "James T. Kirk", Rank = "Captain", Species = "Human", Assignment = "USS Enterprise NCC-1701" },
            new StarTrekCharacter { Id = nextId++, Name = "Spock", Rank = "Commander", Species = "Vulcan/Human", Assignment = "USS Enterprise NCC-1701" },
            new StarTrekCharacter { Id = nextId++, Name = "Leonard McCoy", Rank = "Chief Medical Officer", Species = "Human", Assignment = "USS Enterprise NCC-1701" },
            new StarTrekCharacter { Id = nextId++, Name = "Montgomery Scott", Rank = "Lieutenant Commander", Species = "Human", Assignment = "USS Enterprise NCC-1701" },
            new StarTrekCharacter { Id = nextId++, Name = "Hikaru Sulu", Rank = "Lieutenant", Species = "Human", Assignment = "USS Enterprise NCC-1701" },


            // Characters from Discovery
            new StarTrekCharacter { Id = nextId++, Name = "Michael Burnham", Rank = "Commander", Species = "Human", Assignment = "USS Discovery NCC-1031" },
            new StarTrekCharacter { Id = nextId++, Name = "Saru", Rank = "Commander", Species = "Kelpien", Assignment = "USS Discovery NCC-1031" },
            new StarTrekCharacter { Id = nextId++, Name = "Paul Stamets", Rank = "Lieutenant Commander", Species = "Human", Assignment = "USS Discovery NCC-1031" },
            new StarTrekCharacter { Id = nextId++, Name = "Sylvia Tilly", Rank = "Ensign", Species = "Human", Assignment = "USS Discovery NCC-1031" },
            new StarTrekCharacter { Id = nextId++, Name = "Gabriel Lorca", Rank = "Captain", Species = "Human", Assignment = "USS Discovery NCC-1031" },

            // Characters from Voyager
            new StarTrekCharacter { Id = nextId++, Name = "Kathryn Janeway", Rank = "Captain", Species = "Human", Assignment = "USS Voyager NCC-74656" },
            new StarTrekCharacter { Id = nextId++, Name = "Chakotay", Rank = "Commander", Species = "Human", Assignment = "USS Voyager NCC-74656" },
            new StarTrekCharacter { Id = nextId++, Name = "Tuvok", Rank = "Lieutenant Commander", Species = "Vulcan", Assignment = "USS Voyager NCC-74656" },
            new StarTrekCharacter { Id = nextId++, Name = "B'Elanna Torres", Rank = "Lieutenant", Species = "Human/Klingon", Assignment = "USS Voyager NCC-74656" },
            new StarTrekCharacter { Id = nextId++, Name = "Tom Paris", Rank = "Lieutenant", Species = "Human", Assignment = "USS Voyager NCC-74656" },

            // Characters from Deep Space Nine
            new StarTrekCharacter { Id = nextId++, Name = "Benjamin Sisko", Rank = "Captain", Species = "Human", Assignment = "Deep Space Nine" },
            new StarTrekCharacter { Id = nextId++, Name = "Kira Nerys", Rank = "Colonel", Species = "Bajoran", Assignment = "Deep Space Nine" },
            new StarTrekCharacter { Id = nextId++, Name = "Odo", Rank = "Constable", Species = "Changeling", Assignment = "Deep Space Nine" },
            new StarTrekCharacter { Id = nextId++, Name = "Jadzia Dax", Rank = "Lieutenant Commander", Species = "Trill", Assignment = "Deep Space Nine" },
            new StarTrekCharacter { Id = nextId++, Name = "Julian Bashir", Rank = "Lieutenant", Species = "Human", Assignment = "Deep Space Nine" },

            // Characters from The Next Generation
            new StarTrekCharacter { Id = nextId++, Name = "Jean-Luc Picard", Rank = "Captain", Species = "Human", Assignment = "USS Enterprise NCC-1701-D" },
            new StarTrekCharacter { Id = nextId++, Name = "William Riker", Rank = "Commander", Species = "Human", Assignment = "USS Enterprise NCC-1701-D" },
            new StarTrekCharacter { Id = nextId++, Name = "Data", Rank = "Lieutenant Commander", Species = "Android", Assignment = "USS Enterprise NCC-1701-D" },
            new StarTrekCharacter { Id = nextId++, Name = "Worf", Rank = "Lieutenant", Species = "Klingon", Assignment = "USS Enterprise NCC-1701-D" },
            new StarTrekCharacter { Id = nextId++, Name = "Geordi La Forge", Rank = "Lieutenant Commander", Species = "Human", Assignment = "USS Enterprise NCC-1701-D" },
            });
        }

        public async Task<IEnumerable<StarTrekCharacter>> GetAllCharactersAsync()
        {
            await SlowDown(); // simulate delay
            return characters.AsEnumerable();
        }

        public async Task<StarTrekCharacter> GetCharacterAsync(int id)
        {
            await SlowDown(); // simulate delay
            var character = characters.FirstOrDefault(c => c.Id == id);
            return character;
        }

        public async Task<StarTrekCharacter> AddCharacterAsync(StarTrekCharacter character)
        {
            await SlowDown(); // simulate delay
            character.Id = nextId++;
            characters.Add(character);
            return character;
        }

        public async Task<bool> UpdateCharacterAsync(int id, StarTrekCharacter updatedCharacter)
        {
            await SlowDown(); // simulate delay
            var index = characters.FindIndex(c => c.Id == id);
            if (index != -1)
            {
                characters[index] = updatedCharacter;
                return true;
            }
            return false;
        }

        public async Task<bool> DeleteCharacterAsync(int id)
        {
            await SlowDown(); // simulate delay
            var character = characters.FirstOrDefault(c => c.Id == id);
            if (character != null)
            {
                characters.Remove(character);
                return true;
            }
            return false;
        }

        // All character data operations are slower because puny humanoids are slower than starships!
        private async Task SlowDown()
        {
            // Simulate a delay of 4 seconds
            await Task.Delay(4000);
        }
    }
}