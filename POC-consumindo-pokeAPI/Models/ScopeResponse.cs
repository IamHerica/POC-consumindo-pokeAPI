using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace POC_consumindo_pokeAPI.Models
{
    public class ScopeResponse
    {
        [JsonProperty("count")]
        public long Count { get; set; }

        [JsonProperty("next")]
        public object Next { get; set; }

        [JsonProperty("previous")]
        public object Previous { get; set; }

        [JsonProperty("results")]
        public List<PokemonResponse> Results { get; set; }
    }
}
