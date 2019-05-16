using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace GameOfThrones.Models
{
    public class Character
    {
        [JsonProperty("titles")]
        public IList<string> Titles { get; set; }

        public IList<string> Spouse { get; set; }

        public IList<string> Children { get; set; }

        public IList<string> Allegiance { get; set; }

        [JsonProperty("books")]
        public IList<string> Books { get; set; }

        public int Plod { get; set; }

        public IList<string> Longevity { get; set; }

        public double PlodB { get; set; }

        public int PlodC { get; set; }

        public IList<double> LongevityB { get; set; }

        public IList<object> LongevityC { get; set; }

        [JsonProperty("_id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        public string Slug { get; set; }

        [JsonProperty("gender")]
        public string Gender { get; set; }

        public string Culture { get; set; }

        [JsonProperty("house")]
        public string House { get; set; }

        [JsonProperty("alive")]
        public bool Alive { get; set; }

        public DateTime CreatedAt { get; set; }

        public DateTime UpdatedAt { get; set; }

        public int V { get; set; }

        public Pagerank Pagerank { get; set; }

        [JsonProperty("image")]
        public string Image { get; set; }

        [JsonProperty("birth")]
        public int? Birth { get; set; }

        [JsonProperty("placeOfDeath")]
        public string PlaceOfDeath { get; set; }

        [JsonProperty("death")]
        public int? Death { get; set; }

        [JsonProperty("placeOfBirth")]
        public string PlaceOfBirth { get; set; }

        public int? LongevityStartB { get; set; }

        public string Father { get; set; }

        public string Mother { get; set; }

        public string Heir { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}
