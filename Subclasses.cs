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
    ///The Subclasses class, rolled up by Burrito.
    ///</summary>
    public class Subclasses
    {
        ///<summary>
        ///Searches subclasses based on keywords (or not!).
        ///</summary>
        public static DnDSubclassResults SearchSubclassesAsync(string name = "", string subclass_flavor = "")
        {
            return BurritoCore.API.Get<DnDSubclassResults>(_globals.RootURL + $"subclasses?name={name}&subclass_flavor={subclass_flavor}");
        }

        ///<summary>
        ///Searches subclasses based on keywords (or not!).
        ///</summary>
        public static Task SearchSubclassesAsync(BurritoCore.APICallReturnDelegate<DnDSubclassResults> callback, string name = "", string subclass_flavor = "")
        {
            return BurritoCore.API.GetAsync<DnDSubclassResults>(_globals.RootURL + $"subclasses?name={name}&subclass_flavor={subclass_flavor}", callback);
        }

        ///<summary>
        ///Gets information on a subclass given an index.
        ///</summary>
        public static DnDSubclass GetSubclassAsync(string index = "")
        {
            return BurritoCore.API.Get<DnDSubclass>(_globals.RootURL + $"subclasses/{index}");
        }

        ///<summary>
        ///Gets information on a subclass given an index.
        ///</summary>
        public static Task GetSubclassAsync(BurritoCore.APICallReturnDelegate<DnDSubclass> callback, string index = "")
        {
            return BurritoCore.API.GetAsync<DnDSubclass>(_globals.RootURL + $"subclasses/{index}", callback);
        }

        ///<summary>
        ///Gets feature information on a subclass given an index.
        ///</summary>
        public static SubclassFeatures GetSubclassFeaturesAsync(string index = "")
        {
            return BurritoCore.API.Get<SubclassFeatures>(_globals.RootURL + $"subclasses/{index}/features");
        }

        ///<summary>
        ///Gets feature information on a subclass given an index.
        ///</summary>
        public static Task GetSubclassFeaturesAsync(BurritoCore.APICallReturnDelegate<SubclassFeatures> callback, string index = "")
        {
            return BurritoCore.API.GetAsync<SubclassFeatures>(_globals.RootURL + $"subclasses/{index}/features", callback);
        }

        ///<summary>
        ///Gets information on a single level for a subclass.
        ///</summary>
        public static SubclassLevel GetSubclassLevelAsync(string index = "", string level = "")
        {
            return BurritoCore.API.Get<SubclassLevel>(_globals.RootURL + $"subclasses/{index}/levels/{level}");
        }

        ///<summary>
        ///Gets information on a single level for a subclass.
        ///</summary>
        public static Task GetSubclassLevelAsync(BurritoCore.APICallReturnDelegate<SubclassLevel> callback, string index = "", string level = "")
        {
            return BurritoCore.API.GetAsync<SubclassLevel>(_globals.RootURL + $"subclasses/{index}/levels/{level}", callback);
        }

        ///<summary>
        ///Gets information on features for a single level for a subclass.
        ///</summary>
        public static SubclassLevelFeatures GetSubclassLevelFeaturesAsync(string index = "", string level = "")
        {
            return BurritoCore.API.Get<SubclassLevelFeatures>(_globals.RootURL + $"subclasses/{index}/levels/{level}/features");
        }

        ///<summary>
        ///Gets information on features for a single level for a subclass.
        ///</summary>
        public static Task GetSubclassLevelFeaturesAsync(BurritoCore.APICallReturnDelegate<SubclassLevelFeatures> callback, string index = "", string level = "")
        {
            return BurritoCore.API.GetAsync<SubclassLevelFeatures>(_globals.RootURL + $"subclasses/{index}/levels/{level}/features", callback);
        }
    }
}