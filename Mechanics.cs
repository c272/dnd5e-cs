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
    ///The Mechanics class, rolled up by Burrito.
    ///</summary>
    public class Mechanics
    {
        ///<summary>
        ///Searches all conditions based on keywords (or not!).
        ///</summary>
        public static ConditionResults SearchConditionsAsync(string name = "")
        {
            return BurritoCore.API.Get<ConditionResults>(_globals.RootURL + $"conditions?name={name}");
        }

        ///<summary>
        ///Searches all conditions based on keywords (or not!).
        ///</summary>
        public static Task SearchConditionsAsync(BurritoCore.APICallReturnDelegate<ConditionResults> callback, string name = "")
        {
            return BurritoCore.API.GetAsync<ConditionResults>(_globals.RootURL + $"conditions?name={name}", callback);
        }

        ///<summary>
        ///Gets information on a condition, given an index.
        ///</summary>
        public static Condition GetConditionAsync(string index = "")
        {
            return BurritoCore.API.Get<Condition>(_globals.RootURL + $"conditions/{index}");
        }

        ///<summary>
        ///Gets information on a condition, given an index.
        ///</summary>
        public static Task GetConditionAsync(BurritoCore.APICallReturnDelegate<Condition> callback, string index = "")
        {
            return BurritoCore.API.GetAsync<Condition>(_globals.RootURL + $"conditions/{index}", callback);
        }

        ///<summary>
        ///Searches all damage types based on keywords (or not!).
        ///</summary>
        public static DamageTypeResults SearchDamageTypesAsync(string name = "")
        {
            return BurritoCore.API.Get<DamageTypeResults>(_globals.RootURL + $"damage-types?name={name}");
        }

        ///<summary>
        ///Searches all damage types based on keywords (or not!).
        ///</summary>
        public static Task SearchDamageTypesAsync(BurritoCore.APICallReturnDelegate<DamageTypeResults> callback, string name = "")
        {
            return BurritoCore.API.GetAsync<DamageTypeResults>(_globals.RootURL + $"damage-types?name={name}", callback);
        }

        ///<summary>
        ///Gets information on a damage type, given an index.
        ///</summary>
        public static DamageType GetDamageTypeAsync(string index = "")
        {
            return BurritoCore.API.Get<DamageType>(_globals.RootURL + $"damage-types/{index}");
        }

        ///<summary>
        ///Gets information on a damage type, given an index.
        ///</summary>
        public static Task GetDamageTypeAsync(BurritoCore.APICallReturnDelegate<DamageType> callback, string index = "")
        {
            return BurritoCore.API.GetAsync<DamageType>(_globals.RootURL + $"damage-types/{index}", callback);
        }

        ///<summary>
        ///Searches all magic schools based on keywords (or not!).
        ///</summary>
        public static MagicSchoolResults SearchMagicSchoolsAsync(string name = "")
        {
            return BurritoCore.API.Get<MagicSchoolResults>(_globals.RootURL + $"magic-schools?name={name}");
        }

        ///<summary>
        ///Searches all magic schools based on keywords (or not!).
        ///</summary>
        public static Task SearchMagicSchoolsAsync(BurritoCore.APICallReturnDelegate<MagicSchoolResults> callback, string name = "")
        {
            return BurritoCore.API.GetAsync<MagicSchoolResults>(_globals.RootURL + $"magic-schools?name={name}", callback);
        }

        ///<summary>
        ///Gets information on a magic school, given an index.
        ///</summary>
        public static MagicSchool GetMagicSchoolAsync(string index = "")
        {
            return BurritoCore.API.Get<MagicSchool>(_globals.RootURL + $"magic-schools/{index}");
        }

        ///<summary>
        ///Gets information on a magic school, given an index.
        ///</summary>
        public static Task GetMagicSchoolAsync(BurritoCore.APICallReturnDelegate<MagicSchool> callback, string index = "")
        {
            return BurritoCore.API.GetAsync<MagicSchool>(_globals.RootURL + $"magic-schools/{index}", callback);
        }
    }
}