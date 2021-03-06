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
    ///The IndependentSpellcastingInfo_info class, rolled up by Burrito.
    ///</summary>
    public class IndependentSpellcastingInfo_info
    {
        [JsonProperty("name")]
        public string Name;
        [JsonProperty("desc")]
        public List<string> Desc;
    }
}