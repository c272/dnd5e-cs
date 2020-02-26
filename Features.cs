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
    ///The Features class, rolled up by Burrito.
    ///</summary>
    public class Features
    {
        ///<summary>
        ///Searches all features based on keywords (or not!).
        ///</summary>
        public static FeatureResults SearchFeaturesAsync(string name = "", string level = "")
        {
            return BurritoCore.API.Get<FeatureResults>(_globals.RootURL + $"features?name={name}&level={level}");
        }

        ///<summary>
        ///Searches all features based on keywords (or not!).
        ///</summary>
        public static Task SearchFeaturesAsync(BurritoCore.APICallReturnDelegate<FeatureResults> callback, string name = "", string level = "")
        {
            return BurritoCore.API.GetAsync<FeatureResults>(_globals.RootURL + $"features?name={name}&level={level}", callback);
        }

        ///<summary>
        ///Gets information on a single feature, given an index.
        ///</summary>
        public static Feature GetFeatureAsync(string index = "")
        {
            return BurritoCore.API.Get<Feature>(_globals.RootURL + $"features/{index}");
        }

        ///<summary>
        ///Gets information on a single feature, given an index.
        ///</summary>
        public static Task GetFeatureAsync(BurritoCore.APICallReturnDelegate<Feature> callback, string index = "")
        {
            return BurritoCore.API.GetAsync<Feature>(_globals.RootURL + $"features/{index}", callback);
        }
    }
}