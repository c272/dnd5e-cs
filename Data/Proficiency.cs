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
    ///The Proficiency class, rolled up by Burrito.
    ///</summary>
    public class Proficiency
    {
        [JsonProperty("_id")]
        public string _id;
        [JsonProperty("index")]
        public string Index;
        [JsonProperty("type")]
        public string Type;
        [JsonProperty("name")]
        public string Name;
        [JsonProperty("classes")]
        public List<Proficiency_classes> Classes;
        [JsonProperty("races")]
        public _empty Races;
        [JsonProperty("url")]
        public string Url;
    }
}