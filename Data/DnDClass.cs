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
    ///The DnDClass class, rolled up by Burrito.
    ///</summary>
    public class DnDClass
    {
        [JsonProperty("_id")]
        public string _id;
        [JsonProperty("index")]
        public string Index;
        [JsonProperty("name")]
        public string Name;
        [JsonProperty("hit_die")]
        public int Hit_die;
        [JsonProperty("proficiency_choices")]
        public List<DnDClass_proficiency_choices> Proficiency_choices;
        [JsonProperty("proficiencies")]
        public List<DnDClass_proficiencies> Proficiencies;
        [JsonProperty("saving_throws")]
        public List<DnDClass_saving_throws> Saving_throws;
        [JsonProperty("starting_equipment")]
        public DnDClass_starting_equipment Starting_equipment;
        [JsonProperty("class_levels")]
        public DnDClass_class_levels Class_levels;
        [JsonProperty("subclasses")]
        public List<DnDClass_subclasses> Subclasses;
        [JsonProperty("spellcasting")]
        public DnDClass_spellcasting Spellcasting;
        [JsonProperty("url")]
        public string Url;
    }
}