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
    ///The Subrace_ class, rolled up by Burrito.
    ///</summary>
    public class Subrace_
    {
        [JsonProperty("count")]
        public int Count;
        [JsonProperty("results")]
        public List<Subrace_results> Results;
    }
}