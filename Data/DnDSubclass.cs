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
    ///The DnDSubclass class, rolled up by Burrito.
    ///</summary>
    public class DnDSubclass
    {
        [JsonProperty("_id")]
        public string _id;
        [JsonProperty("index")]
        public string Index;
        [JsonProperty("class")]
        public DnDSubclass_class Class;
        [JsonProperty("name")]
        public string Name;
        [JsonProperty("subclass_flavor")]
        public string Subclass_flavor;
        [JsonProperty("desc")]
        public List<string> Desc;
        [JsonProperty("features")]
        public _empty Features;
        [JsonProperty("url")]
        public string Url;
    }
}