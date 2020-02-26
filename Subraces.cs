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
    ///The Subraces class, rolled up by Burrito.
    ///</summary>
    public class Subraces
    {
        ///<summary>
        ///Gets a list of subraces, given a search term (or not!).
        ///</summary>
        public static SubraceResults SearchSubracesAsync(string name = "")
        {
            return BurritoCore.API.Get<SubraceResults>(_globals.RootURL + $"subraces?name={name}");
        }

        ///<summary>
        ///Gets a list of subraces, given a search term (or not!).
        ///</summary>
        public static Task SearchSubracesAsync(BurritoCore.APICallReturnDelegate<SubraceResults> callback, string name = "")
        {
            return BurritoCore.API.GetAsync<SubraceResults>(_globals.RootURL + $"subraces?name={name}", callback);
        }

        ///<summary>
        ///Gets a subrace, given an index.
        ///</summary>
        public static Subrace GetSubraceAsync(string index = "")
        {
            return BurritoCore.API.Get<Subrace>(_globals.RootURL + $"subraces/{index}");
        }

        ///<summary>
        ///Gets a subrace, given an index.
        ///</summary>
        public static Task GetSubraceAsync(BurritoCore.APICallReturnDelegate<Subrace> callback, string index = "")
        {
            return BurritoCore.API.GetAsync<Subrace>(_globals.RootURL + $"subraces/{index}", callback);
        }

        ///<summary>
        ///Gets traits for a subrace, given an index.
        ///</summary>
        public static SubraceTraits GetSubraceTraitsAsync(string index = "")
        {
            return BurritoCore.API.Get<SubraceTraits>(_globals.RootURL + $"subraces/{index}/traits");
        }

        ///<summary>
        ///Gets traits for a subrace, given an index.
        ///</summary>
        public static Task GetSubraceTraitsAsync(BurritoCore.APICallReturnDelegate<SubraceTraits> callback, string index = "")
        {
            return BurritoCore.API.GetAsync<SubraceTraits>(_globals.RootURL + $"subraces/{index}/traits", callback);
        }

        ///<summary>
        ///Gets proficiencies for a subrace, given an index.
        ///</summary>
        public static SubraceProficiencies GetSubraceProficienciesAsync(string index = "")
        {
            return BurritoCore.API.Get<SubraceProficiencies>(_globals.RootURL + $"subraces/{index}/proficiencies");
        }

        ///<summary>
        ///Gets proficiencies for a subrace, given an index.
        ///</summary>
        public static Task GetSubraceProficienciesAsync(BurritoCore.APICallReturnDelegate<SubraceProficiencies> callback, string index = "")
        {
            return BurritoCore.API.GetAsync<SubraceProficiencies>(_globals.RootURL + $"subraces/{index}/proficiencies", callback);
        }
    }
}