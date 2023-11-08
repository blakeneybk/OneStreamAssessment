using OSA.Backend.Api.One.Client;
using OSA.FrontEnd.Api.Services.Interface;

namespace OSA.FrontEnd.Api.Services
{
    public class BackendApiOneService: IBackendApiOneService
    {
        private readonly IBackendOneApiClientService client;

        public BackendApiOneService(IBackendOneApiClientService client)
        {
            this.client = client;
        }
    }
}
