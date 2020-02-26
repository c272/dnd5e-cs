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
    ///The ArmourEquipment class, rolled up by Burrito.
    ///</summary>
    public class ArmourEquipment
    {
        [JsonProperty("_id")]
        public string _id;
        [JsonProperty("index")]
        public string Index;
        [JsonProperty("name")]
        public string Name;
        [JsonProperty("equipment_category")]
        public string Equipment_category;
        [JsonProperty("armor_category")]
        public string Armor_category;
        [JsonProperty("armor_class")]
        public ArmourEquipment_armor_class Armor_class;
        [JsonProperty("str_minimum")]
        public int Str_minimum;
        [JsonProperty("stealth_disadvantage")]
        public bool Stealth_disadvantage;
        [JsonProperty("weight")]
        public int Weight;
        [JsonProperty("cost")]
        public ArmourEquipment_cost Cost;
        [JsonProperty("url")]
        public string Url;
    }
}