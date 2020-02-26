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
    ///The Language class, rolled up by Burrito.
    ///</summary>
    public class Language
    {
        [JsonProperty("_id")]
        public string _id;
        [JsonProperty("index")]
        public string Index;
        [JsonProperty("name")]
        public string Name;
        [JsonProperty("type")]
        public string Type;
        [JsonProperty("typical_speakers")]
        public List<string> Typical_speakers;
        [JsonProperty("script")]
        public string Script;
        [JsonProperty("url")]
        public string Url;
    }
}