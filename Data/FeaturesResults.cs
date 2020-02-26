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
    ///The FeaturesResults class, rolled up by Burrito.
    ///</summary>
    public class FeaturesResults
    {
        [JsonProperty("count")]
        public int Count;
        [JsonProperty("results")]
        public List<FeaturesResults_results> Results;
    }
}