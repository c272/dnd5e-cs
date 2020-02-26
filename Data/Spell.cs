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
    ///The Spell class, rolled up by Burrito.
    ///</summary>
    public class Spell
    {
        [JsonProperty("_id")]
        public string _id;
        [JsonProperty("index")]
        public string Index;
        [JsonProperty("name")]
        public string Name;
        [JsonProperty("desc")]
        public List<string> Desc;
        [JsonProperty("higher_level")]
        public List<string> Higher_level;
        [JsonProperty("page")]
        public string Page;
        [JsonProperty("range")]
        public string Range;
        [JsonProperty("components")]
        public List<string> Components;
        [JsonProperty("material")]
        public string Material;
        [JsonProperty("ritual")]
        public bool Ritual;
        [JsonProperty("duration")]
        public string Duration;
        [JsonProperty("concentration")]
        public bool Concentration;
        [JsonProperty("casting_time")]
        public string Casting_time;
        [JsonProperty("level")]
        public int Level;
        [JsonProperty("school")]
        public Spell_school School;
        [JsonProperty("classes")]
        public List<Spell_classes> Classes;
        [JsonProperty("subclasses")]
        public List<Spell_subclasses> Subclasses;
        [JsonProperty("url")]
        public string Url;
    }
}