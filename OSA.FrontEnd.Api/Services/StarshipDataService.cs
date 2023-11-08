using OSA.Backend.StarshipApi.Client;
using OSA.FrontEnd.Api.Services.Interface;

namespace OSA.FrontEnd.Api.Services;

public class StarshipDataService: IStarshipDataService
{
    private readonly IStarshipApiClientService client;

    public StarshipDataService(IStarshipApiClientService client)
    {
        this.client = client;
    }

}