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
    ///The Equipment class, rolled up by Burrito.
    ///</summary>
    public class Equipment
    {
        ///<summary>
        ///Searches equipment with a keyword (or not!).
        ///</summary>
        public static EquipmentResults SearchEquipmentAsync(string name = "")
        {
            return BurritoCore.API.Get<EquipmentResults>(_globals.RootURL + $"equipment?name={name}");
        }

        ///<summary>
        ///Searches equipment with a keyword (or not!).
        ///</summary>
        public static Task SearchEquipmentAsync(BurritoCore.APICallReturnDelegate<EquipmentResults> callback, string name = "")
        {
            return BurritoCore.API.GetAsync<EquipmentResults>(_globals.RootURL + $"equipment?name={name}", callback);
        }

        ///<summary>
        ///Gets information on a piece of equipment given an index.
        ///</summary>
        public static Equipment GetEquipmentAsync(string index = "")
        {
            return BurritoCore.API.Get<Equipment>(_globals.RootURL + $"equipment/{index}");
        }

        ///<summary>
        ///Gets information on a piece of equipment given an index.
        ///</summary>
        public static Task GetEquipmentAsync(BurritoCore.APICallReturnDelegate<Equipment> callback, string index = "")
        {
            return BurritoCore.API.GetAsync<Equipment>(_globals.RootURL + $"equipment/{index}", callback);
        }

        ///<summary>
        ///Gets information on a weapon given an index.
        ///</summary>
        public static WeaponEquipment GetWeaponAsync(string wepindex = "")
        {
            return BurritoCore.API.Get<WeaponEquipment>(_globals.RootURL + $"equipment/{wepindex}");
        }

        ///<summary>
        ///Gets information on a weapon given an index.
        ///</summary>
        public static Task GetWeaponAsync(BurritoCore.APICallReturnDelegate<WeaponEquipment> callback, string wepindex = "")
        {
            return BurritoCore.API.GetAsync<WeaponEquipment>(_globals.RootURL + $"equipment/{wepindex}", callback);
        }

        ///<summary>
        ///Gets information on a piece of armour given an index.
        ///</summary>
        public static ArmourEquipment GetArmourAsync(string armourindex = "")
        {
            return BurritoCore.API.Get<ArmourEquipment>(_globals.RootURL + $"equipment/{armourindex}");
        }

        ///<summary>
        ///Gets information on a piece of armour given an index.
        ///</summary>
        public static Task GetArmourAsync(BurritoCore.APICallReturnDelegate<ArmourEquipment> callback, string armourindex = "")
        {
            return BurritoCore.API.GetAsync<ArmourEquipment>(_globals.RootURL + $"equipment/{armourindex}", callback);
        }

        ///<summary>
        ///Searches weapon properties given a keyword (or not!).
        ///</summary>
        public static WeaponPropertiesResults SearchWeaponPropertiesAsync(string name = "")
        {
            return BurritoCore.API.Get<WeaponPropertiesResults>(_globals.RootURL + $"weapon-properties?name={name}");
        }

        ///<summary>
        ///Searches weapon properties given a keyword (or not!).
        ///</summary>
        public static Task SearchWeaponPropertiesAsync(BurritoCore.APICallReturnDelegate<WeaponPropertiesResults> callback, string name = "")
        {
            return BurritoCore.API.GetAsync<WeaponPropertiesResults>(_globals.RootURL + $"weapon-properties?name={name}", callback);
        }

        ///<summary>
        ///Gets weapon properties when provided an index.
        ///</summary>
        public static WeaponProperties GetWeaponPropertiesAsync(string index = "")
        {
            return BurritoCore.API.Get<WeaponProperties>(_globals.RootURL + $"weapon-properties/{index}");
        }

        ///<summary>
        ///Gets weapon properties when provided an index.
        ///</summary>
        public static Task GetWeaponPropertiesAsync(BurritoCore.APICallReturnDelegate<WeaponProperties> callback, string index = "")
        {
            return BurritoCore.API.GetAsync<WeaponProperties>(_globals.RootURL + $"weapon-properties/{index}", callback);
        }
    }
}