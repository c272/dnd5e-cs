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
    ///The Skill class, rolled up by Burrito.
    ///</summary>
    public class Skill
    {
        [JsonProperty("_id")]
        public string _id;
        [JsonProperty("index")]
        public string Index;
        [JsonProperty("name")]
        public string Name;
        [JsonProperty("desc")]
        public List<string> Desc;
        [JsonProperty("ability_score")]
        public Skill_ability_score Ability_score;
        [JsonProperty("url")]
        public string Url;
    }
}