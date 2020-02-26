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
    ///The Race_starting_proficiency_options class, rolled up by Burrito.
    ///</summary>
    public class Race_starting_proficiency_options
    {
        [JsonProperty("choose")]
        public int Choose;
        [JsonProperty("type")]
        public string Type;
        [JsonProperty("from")]
        public List<Race_starting_proficiency_options_from> From;
    }
}