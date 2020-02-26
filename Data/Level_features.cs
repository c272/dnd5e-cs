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
    ///The Level_features class, rolled up by Burrito.
    ///</summary>
    public class Level_features
    {
        [JsonProperty("name")]
        public string Name;
        [JsonProperty("url")]
        public string Url;
    }
}