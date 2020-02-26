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
    ///The DnDClass_starting_equipment class, rolled up by Burrito.
    ///</summary>
    public class DnDClass_starting_equipment
    {
        [JsonProperty("url")]
        public string Url;
        [JsonProperty("class")]
        public string Class;
    }
}