using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using DnD5e.Data;

namespace DnD5e
{
    //<summary>
    ///The Spells class, rolled up by Burrito.
    ///</summary>
    public class Spells
    {
        ///<summary>
        ///Searches spells based on keywords (or not!).
        ///</summary>
        public static SpellResults SearchSpellsAsync(string name = "")
        {
            return BurritoCore.API.Get<SpellResults>(_globals.RootURL + $"spells?name={name}");
        }

        ///<summary>
        ///Searches spells based on keywords (or not!).
        ///</summary>
        public static Task SearchSpellsAsync(BurritoCore.APICallReturnDelegate<SpellResults> callback, string name = "")
        {
            return BurritoCore.API.GetAsync<SpellResults>(_globals.RootURL + $"spells?name={name}", callback);
        }

        ///<summary>
        ///Gets information on a spell, given an index.
        ///</summary>
        public static Spell GetSpellAsync(string index = "")
        {
            return BurritoCore.API.Get<Spell>(_globals.RootURL + $"spells/{index}");
        }

        ///<summary>
        ///Gets information on a spell, given an index.
        ///</summary>
        public static Task GetSpellAsync(BurritoCore.APICallReturnDelegate<Spell> callback, string index = "")
        {
            return BurritoCore.API.GetAsync<Spell>(_globals.RootURL + $"spells/{index}", callback);
        }
    }
}