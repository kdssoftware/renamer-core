using System;
using Newtonsoft.Json;

namespace RenamerCore.Models
{
    public class Movie
    {
        public long Id { get; set; }

        public string Title { get; set; }

        [JsonProperty("release_date")]
        public DateTime ReleaseDate { get; set; }
    }
}
