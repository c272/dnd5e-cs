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
    ///The SubclassLevel class, rolled up by Burrito.
    ///</summary>
    public class SubclassLevel
    {
        [JsonProperty("_id")]
        public string _id;
        [JsonProperty("level")]
        public int Level;
        [JsonProperty("feature_choices")]
        public _empty Feature_choices;
        [JsonProperty("features")]
        public List<SubclassLevel_features> Features;
        [JsonProperty("class")]
        public SubclassLevel_class Class;
        [JsonProperty("subclass")]
        public SubclassLevel_subclass Subclass;
        [JsonProperty("url")]
        public string Url;
        [JsonProperty("index")]
        public int Index;
    }
}