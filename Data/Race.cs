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
    ///The Race class, rolled up by Burrito.
    ///</summary>
    public class Race
    {
        [JsonProperty("_id")]
        public string _id;
        [JsonProperty("index")]
        public string Index;
        [JsonProperty("name")]
        public string Name;
        [JsonProperty("speed")]
        public int Speed;
        [JsonProperty("ability_bonuses")]
        public List<Race_ability_bonuses> Ability_bonuses;
        [JsonProperty("alignment")]
        public string Alignment;
        [JsonProperty("age")]
        public string Age;
        [JsonProperty("size")]
        public string Size;
        [JsonProperty("size_description")]
        public string Size_description;
        [JsonProperty("starting_proficiencies")]
        public List<Race_starting_proficiencies> Starting_proficiencies;
        [JsonProperty("starting_proficiency_options")]
        public Race_starting_proficiency_options Starting_proficiency_options;
        [JsonProperty("languages")]
        public List<Race_languages> Languages;
        [JsonProperty("language_desc")]
        public string Language_desc;
        [JsonProperty("traits")]
        public List<Race_traits> Traits;
        [JsonProperty("subraces")]
        public List<Race_subraces> Subraces;
        [JsonProperty("url")]
        public string Url;
    }
}