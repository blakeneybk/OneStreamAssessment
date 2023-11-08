namespace OSA.FrontEnd.Api.DtoModels
{
    public class StarTrekCharacterDto: IDtoModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Rank { get; set; }
        public string Species { get; set; }
        public string Assignment { get; set; } // e.g., "USS Enterprise"
    }
}
