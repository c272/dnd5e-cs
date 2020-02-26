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
    ///The Monster_special_abilities class, rolled up by Burrito.
    ///</summary>
    public class Monster_special_abilities
    {
        [JsonProperty("name")]
        public string Name;
        [JsonProperty("desc")]
        public string Desc;
    }
}