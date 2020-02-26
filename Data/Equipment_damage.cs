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
    ///The Equipment_damage class, rolled up by Burrito.
    ///</summary>
    public class Equipment_damage
    {
        [JsonProperty("damage_dice")]
        public string Damage_dice;
        [JsonProperty("damage_bonus")]
        public int Damage_bonus;
        [JsonProperty("damage_type")]
        public Equipment_damage_damage_type Damage_type;
    }
}