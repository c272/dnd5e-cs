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
    ///The ClassStartingEquipment_choice_3 class, rolled up by Burrito.
    ///</summary>
    public class ClassStartingEquipment_choice_3
    {
        [JsonProperty("choose")]
        public int Choose;
        [JsonProperty("type")]
        public string Type;
        [JsonProperty("from")]
        public List<ClassStartingEquipment_choice_3_from> From;
    }
}