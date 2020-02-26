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
    ///The Monster class, rolled up by Burrito.
    ///</summary>
    public class Monster
    {
        [JsonProperty("_id")]
        public string _id;
        [JsonProperty("index")]
        public string Index;
        [JsonProperty("name")]
        public string Name;
        [JsonProperty("size")]
        public string Size;
        [JsonProperty("type")]
        public string Type;
        [JsonProperty("subtype")]
        public object Subtype;
        [JsonProperty("alignment")]
        public string Alignment;
        [JsonProperty("armor_class")]
        public int Armor_class;
        [JsonProperty("hit_points")]
        public int Hit_points;
        [JsonProperty("hit_dice")]
        public string Hit_dice;
        [JsonProperty("speed")]
        public Monster_speed Speed;
        [JsonProperty("strength")]
        public int Strength;
        [JsonProperty("dexterity")]
        public int Dexterity;
        [JsonProperty("constitution")]
        public int Constitution;
        [JsonProperty("intelligence")]
        public int Intelligence;
        [JsonProperty("wisdom")]
        public int Wisdom;
        [JsonProperty("charisma")]
        public int Charisma;
        [JsonProperty("proficiencies")]
        public List<Monster_proficiencies> Proficiencies;
        [JsonProperty("damage_vulnerabilities")]
        public _empty Damage_vulnerabilities;
        [JsonProperty("damage_resistances")]
        public _empty Damage_resistances;
        [JsonProperty("damage_immunities")]
        public _empty Damage_immunities;
        [JsonProperty("condition_immunities")]
        public _empty Condition_immunities;
        [JsonProperty("senses")]
        public Monster_senses Senses;
        [JsonProperty("languages")]
        public string Languages;
        [JsonProperty("challenge_rating")]
        public int Challenge_rating;
        [JsonProperty("special_abilities")]
        public List<Monster_special_abilities> Special_abilities;
        [JsonProperty("actions")]
        public List<Monster_actions> Actions;
        [JsonProperty("legendary_actions")]
        public List<Monster_legendary_actions> Legendary_actions;
        [JsonProperty("url")]
        public string Url;
    }
}