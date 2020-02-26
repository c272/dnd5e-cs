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
    ///The Subrace class, rolled up by Burrito.
    ///</summary>
    public class Subrace
    {
        [JsonProperty("_id")]
        public string _id;
        [JsonProperty("index")]
        public string Index;
        [JsonProperty("name")]
        public string Name;
        [JsonProperty("race")]
        public Subrace_race Race;
        [JsonProperty("desc")]
        public string Desc;
        [JsonProperty("ability_bonuses")]
        public List<Subrace_ability_bonuses> Ability_bonuses;
        [JsonProperty("starting_proficiencies")]
        public _empty Starting_proficiencies;
        [JsonProperty("languages")]
        public _empty Languages;
        [JsonProperty("racial_traits")]
        public List<Subrace_racial_traits> Racial_traits;
        [JsonProperty("url")]
        public string Url;
    }
}