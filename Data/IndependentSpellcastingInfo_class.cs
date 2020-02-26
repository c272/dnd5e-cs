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
    ///The IndependentSpellcastingInfo_class class, rolled up by Burrito.
    ///</summary>
    public class IndependentSpellcastingInfo_class
    {
        [JsonProperty("url")]
        public string Url;
        [JsonProperty("name")]
        public string Name;
    }
}