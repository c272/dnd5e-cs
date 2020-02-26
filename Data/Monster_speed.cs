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
    ///The Monster_speed class, rolled up by Burrito.
    ///</summary>
    public class Monster_speed
    {
        [JsonProperty("walk")]
        public string Walk;
        [JsonProperty("swim")]
        public string Swim;
    }
}