﻿namespace CarDealerSystem.DTOs.Import
{
    using Newtonsoft.Json;

    public class ImportCarDto
    {
        public ImportCarDto()
        {
            this.PartsId = new HashSet<int>();
        }

        [JsonProperty("make")]
        public string Make { get; set; } = null!;

        [JsonProperty("model")]
        public string Model { get; set; } = null!;

        [JsonProperty("traveledDistance")]
        public long TraveledDistance { get; set; }

        [JsonProperty("partsId")]
        public virtual ICollection<int> PartsId { get; set; }
    }
}
