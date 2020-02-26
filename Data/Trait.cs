using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using DnD5e.Data;

namespace DnD5e.Data
{
    //<summary>
    ///The Trait class, rolled up by Burrito.
    ///</summary>
    public class Trait
    {
        [JsonProperty("_id")]
        public string _id;
        [JsonProperty("index")]
        public string Index;
        [JsonProperty("races")]
        public List<Trait_races> Races;
        [JsonProperty("subraces")]
        public List<Trait_subraces> Subraces;
        [JsonProperty("name")]
        public string Name;
        [JsonProperty("desc")]
        public List<string> Desc;
        [JsonProperty("url")]
        public string Url;
    }
}