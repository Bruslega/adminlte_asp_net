﻿using Newtonsoft.Json;

namespace AspMVCAdminLTE.Models
{
    public partial class SampleData
    {
        [JsonProperty("ID")]
        public long Id { get; set; }

        [JsonProperty("User")]
        public string User { get; set; }

        [JsonProperty("Date")]
        public string Date { get; set; }

        [JsonProperty("Status")]
        public string Status { get; set; }

        [JsonProperty("Reason")]
        public string Reason { get; set; }
    }
}