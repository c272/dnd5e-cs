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
    ///The StartingEquipment class, rolled up by Burrito.
    ///</summary>
    public class StartingEquipment
    {
        ///<summary>
        ///Gets starting equipment information, given an index.
        ///</summary>
        public static IndependentStartingEquipment GetStartingEquipmentAsync(string index = "")
        {
            return BurritoCore.API.Get<IndependentStartingEquipment>(_globals.RootURL + $"starting-equipment/{index}");
        }

        ///<summary>
        ///Gets starting equipment information, given an index.
        ///</summary>
        public static Task GetStartingEquipmentAsync(BurritoCore.APICallReturnDelegate<IndependentStartingEquipment> callback, string index = "")
        {
            return BurritoCore.API.GetAsync<IndependentStartingEquipment>(_globals.RootURL + $"starting-equipment/{index}", callback);
        }
    }
}