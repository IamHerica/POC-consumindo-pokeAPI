using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace POC_consumindo_pokeAPI.Models
{
    public class PokemonResponse
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("url")]
        public Uri Url { get; set; }
    }
}
