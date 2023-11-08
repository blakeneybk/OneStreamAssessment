﻿namespace OSA.Backend.Api.One.Models
{
    public class StarTrekCharacter: IDataModel
    {
        public string Name { get; set; }
        public string Rank { get; set; }
        public string Species { get; set; }
        public string Assignment { get; set; } // e.g., "USS Enterprise"
    }
}
