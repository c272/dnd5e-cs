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
    ///The Ability class, rolled up by Burrito.
    ///</summary>
    public class Ability
    {
        [JsonProperty("_id")]
        public string _id;
        [JsonProperty("index")]
        public string Index;
        [JsonProperty("name")]
        public string Name;
        [JsonProperty("full_name")]
        public string Full_name;
        [JsonProperty("desc")]
        public List<string> Desc;
        [JsonProperty("skills")]
        public List<Ability_skills> Skills;
        [JsonProperty("url")]
        public string Url;
    }
}