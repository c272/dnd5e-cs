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
    ///The Feature class, rolled up by Burrito.
    ///</summary>
    public class Feature
    {
        [JsonProperty("class")]
        public Feature_class Class;
        [JsonProperty("desc")]
        public List<string> Desc;
        [JsonProperty("_id")]
        public string _id;
        [JsonProperty("index")]
        public string Index;
        [JsonProperty("name")]
        public string Name;
        [JsonProperty("level")]
        public int Level;
        [JsonProperty("url")]
        public string Url;
    }
}