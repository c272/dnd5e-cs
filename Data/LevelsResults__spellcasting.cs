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
    ///The LevelsResults__spellcasting class, rolled up by Burrito.
    ///</summary>
    public class LevelsResults__spellcasting
    {
        [JsonProperty("cantrips_known")]
        public int Cantrips_known;
        [JsonProperty("spells_known")]
        public int Spells_known;
        [JsonProperty("spell_slots_level_1")]
        public int Spell_slots_level_1;
        [JsonProperty("spell_slots_level_2")]
        public int Spell_slots_level_2;
        [JsonProperty("spell_slots_level_3")]
        public int Spell_slots_level_3;
        [JsonProperty("spell_slots_level_4")]
        public int Spell_slots_level_4;
        [JsonProperty("spell_slots_level_5")]
        public int Spell_slots_level_5;
        [JsonProperty("spell_slots_level_6")]
        public int Spell_slots_level_6;
        [JsonProperty("spell_slots_level_7")]
        public int Spell_slots_level_7;
        [JsonProperty("spell_slots_level_8")]
        public int Spell_slots_level_8;
        [JsonProperty("spell_slots_level_9")]
        public int Spell_slots_level_9;
    }
}