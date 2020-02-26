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
    ///The IndependentStartingEquipment class, rolled up by Burrito.
    ///</summary>
    public class IndependentStartingEquipment
    {
        [JsonProperty("class")]
        public IndependentStartingEquipment_class Class;
        [JsonProperty("_id")]
        public string _id;
        [JsonProperty("index")]
        public int Index;
        [JsonProperty("starting_equipment")]
        public List<IndependentStartingEquipment_starting_equipment> Starting_equipment;
        [JsonProperty("choices_to_make")]
        public int Choices_to_make;
        [JsonProperty("choice_1")]
        public List<IndependentStartingEquipment_choice_1> Choice_1;
        [JsonProperty("choice_2")]
        public List<IndependentStartingEquipment_choice_2> Choice_2;
        [JsonProperty("url")]
        public string Url;
    }
}