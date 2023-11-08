using OSA.Backend.CharacterApi.Client;
using OSA.FrontEnd.Api.Services.Interface;

namespace OSA.FrontEnd.Api.Services
{
    public class CharacterDataService: ICharacterDataService
    {
        private readonly ICharacterApiClientService client;

        public CharacterDataService(ICharacterApiClientService client)
        {
            this.client = client;
        }
    }
}
