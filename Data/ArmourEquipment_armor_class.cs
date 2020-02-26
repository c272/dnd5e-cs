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
    ///The ArmourEquipment_armor_class class, rolled up by Burrito.
    ///</summary>
    public class ArmourEquipment_armor_class
    {
        [JsonProperty("base")]
        public int Base;
        [JsonProperty("dex_bonus")]
        public bool Dex_bonus;
        [JsonProperty("max_bonus")]
        public object Max_bonus;
    }
}