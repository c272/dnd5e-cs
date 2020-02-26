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
    ///The ClassStartingEquipment class, rolled up by Burrito.
    ///</summary>
    public class ClassStartingEquipment
    {
        [JsonProperty("class")]
        public ClassStartingEquipment_class Class;
        [JsonProperty("_id")]
        public string _id;
        [JsonProperty("index")]
        public int Index;
        [JsonProperty("starting_equipment")]
        public List<ClassStartingEquipment_starting_equipment> Starting_equipment;
        [JsonProperty("choices_to_make")]
        public int Choices_to_make;
        [JsonProperty("choice_1")]
        public List<ClassStartingEquipment_choice_1> Choice_1;
        [JsonProperty("choice_2")]
        public List<ClassStartingEquipment_choice_2> Choice_2;
        [JsonProperty("choice_3")]
        public List<ClassStartingEquipment_choice_3> Choice_3;
        [JsonProperty("choice_4")]
        public List<ClassStartingEquipment_choice_4> Choice_4;
        [JsonProperty("url")]
        public string Url;
    }
}