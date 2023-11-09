using Microsoft.AspNetCore.Mvc;

namespace OSA.FrontEnd.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class DebugController : ControllerBase
    {
        //private readonly ICharacterDataService _backendApiOneService;
        //private readonly IStarshipDataService _backendApiTwoService;

        //public DebugController(ICharacterDataService backendApiOneService, IStarshipDataService backendApiTwoService)
        //{
        //    _backendApiOneService = backendApiOneService;
        //    _backendApiTwoService = backendApiTwoService;
        //}

        //// GET api/debug
        //[HttpGet]
        //public async Task<IActionResult> GetAllData()
        //{ 
        //    Task<IEnumerable<StarTrekCharacterDto>> backendOneDataTask = _backendApiOneService.GetDataAsync();
        //    Task<IEnumerable<StarTrekStarshipDto>> backendTwoDataTask = _backendApiTwoService.GetDataAsync();

        //    return Ok(new
        //    {
        //        CharacterApiData = await backendOneDataTask,
        //        StarshipApiData = await backendTwoDataTask
        //    });
        //}

        //// GET api/debug/characters
        //[HttpGet("characters")]
        //public async Task<IActionResult> GetCharacters()
        //{ 
        //    Task<IEnumerable<StarTrekCharacterDto>> backendOneDataTask = _backendApiOneService.GetDataAsync();
        //    Task<IEnumerable<StarTrekStarshipDto>> backendTwoDataTask = _backendApiTwoService.GetDataAsync();

        //    return Ok(new
        //    {
        //        CharacterApiData = await backendOneDataTask,
        //        StarshipApiData = await backendTwoDataTask
        //    });
        //}

        //// GET api/debug/starships
        //[HttpGet("starships")]
        //public async Task<IActionResult> GetStarships()
        //{ 
        //    Task<IEnumerable<StarTrekCharacterDto>> backendOneDataTask = _backendApiOneService.GetDataAsync();
        //    Task<IEnumerable<StarTrekStarshipDto>> backendTwoDataTask = _backendApiTwoService.GetDataAsync();

        //    return Ok(new
        //    {
        //        CharacterApiData = await backendOneDataTask,
        //        StarshipApiData = await backendTwoDataTask
        //    });
        //}

        //// POST api/debug
        //[HttpPost]
        //public async Task<IActionResult> CreateCharacter([FromBody] StarTrekCharacterDto data)
        //{
        //    var backendOneTask = _backendApiOneService.ProcessDataAsync(data);
        //    var backendTwoTask = _backendApiTwoService.ProcessDataAsync(data);


        //    return Ok(new
        //    {
        //        CharacterApiResponse = await backendOneTask,
        //        StarshipApiResponse = await backendTwoTask
        //    });
        //}

        //// POST api/debug
        //[HttpPost]
        //public async Task<IActionResult> CreateStarship([FromBody] StarTrekStarshipDto data)
        //{
        //    var backendOneTask = _backendApiOneService.ProcessDataAsync(data);
        //    var backendTwoTask = _backendApiTwoService.ProcessDataAsync(data);


        //    return Ok(new
        //    {
        //        CharacterApiResponse = await backendOneTask,
        //        StarshipApiResponse = await backendTwoTask
        //    });
        //}
    }
}
