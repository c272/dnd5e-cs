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
    ///The Monsters class, rolled up by Burrito.
    ///</summary>
    public class Monsters
    {
        ///<summary>
        ///Searches monsters based on keywords (or not!).
        ///</summary>
        public static MonsterResults SearchMonstersAsync(string name = "")
        {
            return BurritoCore.API.Get<MonsterResults>(_globals.RootURL + $"monsters?name={name}");
        }

        ///<summary>
        ///Searches monsters based on keywords (or not!).
        ///</summary>
        public static Task SearchMonstersAsync(BurritoCore.APICallReturnDelegate<MonsterResults> callback, string name = "")
        {
            return BurritoCore.API.GetAsync<MonsterResults>(_globals.RootURL + $"monsters?name={name}", callback);
        }

        ///<summary>
        ///Gets information on a monster, given an index.
        ///</summary>
        public static Monster GetMonsterAsync(string index = "")
        {
            return BurritoCore.API.Get<Monster>(_globals.RootURL + $"monsters/{index}");
        }

        ///<summary>
        ///Gets information on a monster, given an index.
        ///</summary>
        public static Task GetMonsterAsync(BurritoCore.APICallReturnDelegate<Monster> callback, string index = "")
        {
            return BurritoCore.API.GetAsync<Monster>(_globals.RootURL + $"monsters/{index}", callback);
        }
    }
}