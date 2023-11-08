namespace OSA.Backend.Api.Two.Models
{
    public class StarTrekStarship: IDataModel
    {
        public string Name { get; set; }
        public string Class { get; set; } // e.g., "Constitution"
        public string Registry { get; set; } // e.g., "NCC-1701"
        public string Captain { get; set; }
    }
}
