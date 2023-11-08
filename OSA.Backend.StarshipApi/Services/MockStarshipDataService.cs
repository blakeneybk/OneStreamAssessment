using OSA.Backend.StarshipApi.Models;

namespace OSA.Backend.StarshipApi.Services
{
    public class MockStarshipDataService : IDataService
    {
        private readonly List<StarTrekStarship> starships = new();
        private int nextId = 1;

        public MockStarshipDataService()
        {
            // Initialize with some starships
            starships.AddRange(new[]
            {
                new StarTrekStarship { Id = nextId++, Name = "USS Enterprise", Class = "Constitution", Registry = "NCC-1701", Captain = "James T. Kirk" },
                new StarTrekStarship { Id = nextId++, Name = "USS Voyager", Class = "Intrepid", Registry = "NCC-74656", Captain = "Kathryn Janeway" },
                new StarTrekStarship { Id = nextId++, Name = "USS Defiant", Class = "Defiant", Registry = "NX-74205", Captain = "Benjamin Sisko" },
                new StarTrekStarship { Id = nextId++, Name = "USS Discovery", Class = "Crossfield", Registry = "NCC-1031", Captain = "Gabriel Lorca" },
                new StarTrekStarship { Id = nextId++, Name = "USS Enterprise-D", Class = "Galaxy", Registry = "NCC-1701-D", Captain = "Jean-Luc Picard" }
            });
        }

        public Task<IEnumerable<StarTrekStarship>> GetAllStarshipsAsync()
        {
            return Task.FromResult(starships.AsEnumerable());
        }

        public Task<StarTrekStarship> GetStarshipAsync(int id)
        {
            var starship = starships.FirstOrDefault(s => s.Id == id);
            return Task.FromResult(starship);
        }

        public Task<StarTrekStarship> AddStarshipAsync(StarTrekStarship starship)
        {
            starship.Id = nextId++;
            starships.Add(starship);
            return Task.FromResult(starship);
        }

        public Task<bool> UpdateStarshipAsync(int id, StarTrekStarship starship)
        {
            var index = starships.FindIndex(s => s.Id == id);
            if (index != -1)
            {
                starships[index] = starship;
                return Task.FromResult(true);
            }

            return Task.FromResult(false);
        }

        public Task<bool> DeleteStarshipAsync(int id)
        {
            var starship = starships.FirstOrDefault(s => s.Id == id);
            if (starship != null)
            {
                starships.Remove(starship);
                return Task.FromResult(true);
            }

            return Task.FromResult(false);
        }
    }
}
