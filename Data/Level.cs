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
    ///The Level class, rolled up by Burrito.
    ///</summary>
    public class Level
    {
        [JsonProperty("_id")]
        public string _id;
        [JsonProperty("level")]
        public int Level;
        [JsonProperty("ability_score_bonuses")]
        public int Ability_score_bonuses;
        [JsonProperty("prof_bonus")]
        public int Prof_bonus;
        [JsonProperty("feature_choices")]
        public _empty Feature_choices;
        [JsonProperty("features")]
        public List<Level_features> Features;
        [JsonProperty("spellcasting")]
        public Level_spellcasting Spellcasting;
        [JsonProperty("class_specific")]
        public Level_class_specific Class_specific;
        [JsonProperty("index")]
        public int Index;
        [JsonProperty("class")]
        public Level_class Class;
        [JsonProperty("url")]
        public string Url;
    }
}