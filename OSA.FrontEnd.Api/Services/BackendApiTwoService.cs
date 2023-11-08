using OSA.Backend.Api.Two.Client;
using OSA.FrontEnd.Api.Services.Interface;

namespace OSA.FrontEnd.Api.Services;

public class BackendApiTwoService: IBackendApiTwoService
{
    private readonly IBackendTwoApiClientService client;

    public BackendApiTwoService(IBackendTwoApiClientService client)
    {
        this.client = client;
    }

}