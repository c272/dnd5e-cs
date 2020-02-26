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
    ///The Race_traits class, rolled up by Burrito.
    ///</summary>
    public class Race_traits
    {
        [JsonProperty("name")]
        public string Name;
        [JsonProperty("url")]
        public string Url;
    }
}