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
    ///The Equipment_damage_damage_type class, rolled up by Burrito.
    ///</summary>
    public class Equipment_damage_damage_type
    {
        [JsonProperty("url")]
        public string Url;
        [JsonProperty("name")]
        public string Name;
    }
}