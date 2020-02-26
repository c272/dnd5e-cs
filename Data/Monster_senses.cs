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
    ///The Monster_senses class, rolled up by Burrito.
    ///</summary>
    public class Monster_senses
    {
        [JsonProperty("darkvision")]
        public string Darkvision;
        [JsonProperty("passive_perception")]
        public int Passive_perception;
    }
}