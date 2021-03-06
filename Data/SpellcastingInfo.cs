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
    ///The SpellcastingInfo class, rolled up by Burrito.
    ///</summary>
    public class SpellcastingInfo
    {
        [JsonProperty("class")]
        public SpellcastingInfo_class Class;
        [JsonProperty("_id")]
        public string _id;
        [JsonProperty("index")]
        public int Index;
        [JsonProperty("level")]
        public int Level;
        [JsonProperty("spellcasting_ability")]
        public SpellcastingInfo_spellcasting_ability Spellcasting_ability;
        [JsonProperty("info")]
        public List<SpellcastingInfo_info> Info;
        [JsonProperty("url")]
        public string Url;
    }
}