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
    ///The WeaponEquipment_cost class, rolled up by Burrito.
    ///</summary>
    public class WeaponEquipment_cost
    {
        [JsonProperty("quantity")]
        public int Quantity;
        [JsonProperty("unit")]
        public string Unit;
    }
}