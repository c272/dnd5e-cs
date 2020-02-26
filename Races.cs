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
    ///The Races class, rolled up by Burrito.
    ///</summary>
    public class Races
    {
        ///<summary>
        ///Searches for races, given a search term (or not!).
        ///</summary>
        public static RacesResults SearchRacesAsync(string name = "", string speed = "", string alignment = "", string age = "", string size = "", string size_description = "")
        {
            return BurritoCore.API.Get<RacesResults>(_globals.RootURL + $"races?name={name}&speed={speed}&alignment={alignment}&age={age}&size={size}&size_description={size_description}");
        }

        ///<summary>
        ///Searches for races, given a search term (or not!).
        ///</summary>
        public static Task SearchRacesAsync(BurritoCore.APICallReturnDelegate<RacesResults> callback, string name = "", string speed = "", string alignment = "", string age = "", string size = "", string size_description = "")
        {
            return BurritoCore.API.GetAsync<RacesResults>(_globals.RootURL + $"races?name={name}&speed={speed}&alignment={alignment}&age={age}&size={size}&size_description={size_description}", callback);
        }

        ///<summary>
        ///Gets specific race information, given an index.
        ///</summary>
        public static Race GetRaceAsync(string index = "")
        {
            return BurritoCore.API.Get<Race>(_globals.RootURL + $"races/{index}");
        }

        ///<summary>
        ///Gets specific race information, given an index.
        ///</summary>
        public static Task GetRaceAsync(BurritoCore.APICallReturnDelegate<Race> callback, string index = "")
        {
            return BurritoCore.API.GetAsync<Race>(_globals.RootURL + $"races/{index}", callback);
        }

        ///<summary>
        ///Gets subraces for a given race, given an index.
        ///</summary>
        public static Subrace_ GetSubracesAsync(string index = "")
        {
            return BurritoCore.API.Get<Subrace_>(_globals.RootURL + $"races/{index}/subraces");
        }

        ///<summary>
        ///Gets subraces for a given race, given an index.
        ///</summary>
        public static Task GetSubracesAsync(BurritoCore.APICallReturnDelegate<Subrace_> callback, string index = "")
        {
            return BurritoCore.API.GetAsync<Subrace_>(_globals.RootURL + $"races/{index}/subraces", callback);
        }

        ///<summary>
        ///Gets traits for a given race, given an index.
        ///</summary>
        public static RaceTraits GetRaceTraitsAsync(string index = "")
        {
            return BurritoCore.API.Get<RaceTraits>(_globals.RootURL + $"races/{index}/traits");
        }

        ///<summary>
        ///Gets traits for a given race, given an index.
        ///</summary>
        public static Task GetRaceTraitsAsync(BurritoCore.APICallReturnDelegate<RaceTraits> callback, string index = "")
        {
            return BurritoCore.API.GetAsync<RaceTraits>(_globals.RootURL + $"races/{index}/traits", callback);
        }
    }
}