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
    ///The Traits class, rolled up by Burrito.
    ///</summary>
    public class Traits
    {
        ///<summary>
        ///Searches traits by a search term (or not!)
        ///</summary>
        public static TraitResults SearchTraitsAsync(string name = "")
        {
            return BurritoCore.API.Get<TraitResults>(_globals.RootURL + $"traits?name={name}");
        }

        ///<summary>
        ///Searches traits by a search term (or not!)
        ///</summary>
        public static Task SearchTraitsAsync(BurritoCore.APICallReturnDelegate<TraitResults> callback, string name = "")
        {
            return BurritoCore.API.GetAsync<TraitResults>(_globals.RootURL + $"traits?name={name}", callback);
        }

        ///<summary>
        ///Gets information on a trait (given an index).
        ///</summary>
        public static Trait GetTraitAsync(string index = "")
        {
            return BurritoCore.API.Get<Trait>(_globals.RootURL + $"traits/{index}");
        }

        ///<summary>
        ///Gets information on a trait (given an index).
        ///</summary>
        public static Task GetTraitAsync(BurritoCore.APICallReturnDelegate<Trait> callback, string index = "")
        {
            return BurritoCore.API.GetAsync<Trait>(_globals.RootURL + $"traits/{index}", callback);
        }
    }
}