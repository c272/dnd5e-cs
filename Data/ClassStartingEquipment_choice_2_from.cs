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
    ///The ClassStartingEquipment_choice_2_from class, rolled up by Burrito.
    ///</summary>
    public class ClassStartingEquipment_choice_2_from
    {
        [JsonProperty("item")]
        public ClassStartingEquipment_choice_2_from_item Item;
        [JsonProperty("quantity")]
        public int Quantity;
    }
}