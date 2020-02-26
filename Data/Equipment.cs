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
    ///The Equipment class, rolled up by Burrito.
    ///</summary>
    public class Equipment
    {
        [JsonProperty("_id")]
        public string _id;
        [JsonProperty("index")]
        public string Index;
        [JsonProperty("name")]
        public string Name;
        [JsonProperty("equipment_category")]
        public string Equipment_category;
        [JsonProperty("weapon_category")]
        public string Weapon_category;
        [JsonProperty("weapon_range")]
        public string Weapon_range;
        [JsonProperty("category_range")]
        public string Category_range;
        [JsonProperty("cost")]
        public Equipment_cost Cost;
        [JsonProperty("damage")]
        public Equipment_damage Damage;
        [JsonProperty("range")]
        public Equipment_range Range;
        [JsonProperty("weight")]
        public int Weight;
        [JsonProperty("properties")]
        public List<Equipment_properties> Properties;
        [JsonProperty("url")]
        public string Url;
    }
}