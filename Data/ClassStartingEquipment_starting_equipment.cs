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
    ///The ClassStartingEquipment_starting_equipment class, rolled up by Burrito.
    ///</summary>
    public class ClassStartingEquipment_starting_equipment
    {
        [JsonProperty("item")]
        public ClassStartingEquipment_starting_equipment_item Item;
        [JsonProperty("quantity")]
        public int Quantity;
    }
}