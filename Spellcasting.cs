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
    ///The Spellcasting class, rolled up by Burrito.
    ///</summary>
    public class Spellcasting
    {
        ///<summary>
        ///Gets spellcasting information, given an index.
        ///</summary>
        public static IndependentSpellcastingInfo GetSpellcastingInfoAsync(string index = "")
        {
            return BurritoCore.API.Get<IndependentSpellcastingInfo>(_globals.RootURL + $"spellcasting/{index}");
        }

        ///<summary>
        ///Gets spellcasting information, given an index.
        ///</summary>
        public static Task GetSpellcastingInfoAsync(BurritoCore.APICallReturnDelegate<IndependentSpellcastingInfo> callback, string index = "")
        {
            return BurritoCore.API.GetAsync<IndependentSpellcastingInfo>(_globals.RootURL + $"spellcasting/{index}", callback);
        }
    }
}