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
    ///The Level_class_specific class, rolled up by Burrito.
    ///</summary>
    public class Level_class_specific
    {
        [JsonProperty("invocations_known")]
        public int Invocations_known;
        [JsonProperty("mystic_arcanum_level_6")]
        public int Mystic_arcanum_level_6;
        [JsonProperty("mystic_arcanum_level_7")]
        public int Mystic_arcanum_level_7;
        [JsonProperty("mystic_arcanum_level_8")]
        public int Mystic_arcanum_level_8;
        [JsonProperty("mystic_arcanum_level_9")]
        public int Mystic_arcanum_level_9;
    }
}