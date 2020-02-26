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
    ///The Classes class, rolled up by Burrito.
    ///</summary>
    public class Classes
    {
        ///<summary>
        ///Gets a list of classes matching a given name (or none at all!)
        ///</summary>
        public static ClassSearchResults SearchClassesAsync(string name = "", string hit_die = "")
        {
            return BurritoCore.API.Get<ClassSearchResults>(_globals.RootURL + $"classes?name={name}&hit_die={hit_die}");
        }

        ///<summary>
        ///Gets a list of classes matching a given name (or none at all!)
        ///</summary>
        public static Task SearchClassesAsync(BurritoCore.APICallReturnDelegate<ClassSearchResults> callback, string name = "", string hit_die = "")
        {
            return BurritoCore.API.GetAsync<ClassSearchResults>(_globals.RootURL + $"classes?name={name}&hit_die={hit_die}", callback);
        }

        ///<summary>
        ///Gets a specific class, given an class index.
        ///</summary>
        public static DnDClass GetClassAsync(string index = "")
        {
            return BurritoCore.API.Get<DnDClass>(_globals.RootURL + $"classes/{index}");
        }

        ///<summary>
        ///Gets a specific class, given an class index.
        ///</summary>
        public static Task GetClassAsync(BurritoCore.APICallReturnDelegate<DnDClass> callback, string index = "")
        {
            return BurritoCore.API.GetAsync<DnDClass>(_globals.RootURL + $"classes/{index}", callback);
        }

        ///<summary>
        ///Gets a list of subclasses from a parent class index matching a given name (or none at all!)
        ///</summary>
        public static SubclassSearchResults SearchSubclassesAsync(string index = "")
        {
            return BurritoCore.API.Get<SubclassSearchResults>(_globals.RootURL + $"classes/{index}/subclasses");
        }

        ///<summary>
        ///Gets a list of subclasses from a parent class index matching a given name (or none at all!)
        ///</summary>
        public static Task SearchSubclassesAsync(BurritoCore.APICallReturnDelegate<SubclassSearchResults> callback, string index = "")
        {
            return BurritoCore.API.GetAsync<SubclassSearchResults>(_globals.RootURL + $"classes/{index}/subclasses", callback);
        }

        ///<summary>
        ///Gets the starting equipment for a given class.
        ///</summary>
        public static ClassStartingEquipment GetStartingEquipmentAsync(string index = "")
        {
            return BurritoCore.API.Get<ClassStartingEquipment>(_globals.RootURL + $"classes/{index}/starting-equipment");
        }

        ///<summary>
        ///Gets the starting equipment for a given class.
        ///</summary>
        public static Task GetStartingEquipmentAsync(BurritoCore.APICallReturnDelegate<ClassStartingEquipment> callback, string index = "")
        {
            return BurritoCore.API.GetAsync<ClassStartingEquipment>(_globals.RootURL + $"classes/{index}/starting-equipment", callback);
        }

        ///<summary>
        ///Gets the spellcasting information for a given class.
        ///</summary>
        public static SpellcastingInfo GetSpellcastingInfoAsync(string index = "")
        {
            return BurritoCore.API.Get<SpellcastingInfo>(_globals.RootURL + $"classes/{index}/spellcasting");
        }

        ///<summary>
        ///Gets the spellcasting information for a given class.
        ///</summary>
        public static Task GetSpellcastingInfoAsync(BurritoCore.APICallReturnDelegate<SpellcastingInfo> callback, string index = "")
        {
            return BurritoCore.API.GetAsync<SpellcastingInfo>(_globals.RootURL + $"classes/{index}/spellcasting", callback);
        }

        ///<summary>
        ///Gets spells available for a given class.
        ///</summary>
        public static SpellsResults GetSpellsForClassAsync(string index = "")
        {
            return BurritoCore.API.Get<SpellsResults>(_globals.RootURL + $"classes/{index}/spells");
        }

        ///<summary>
        ///Gets spells available for a given class.
        ///</summary>
        public static Task GetSpellsForClassAsync(BurritoCore.APICallReturnDelegate<SpellsResults> callback, string index = "")
        {
            return BurritoCore.API.GetAsync<SpellsResults>(_globals.RootURL + $"classes/{index}/spells", callback);
        }

        ///<summary>
        ///Gets the features available for a given class.
        ///</summary>
        public static FeaturesResults GetFeaturesForClassAsync(string index = "")
        {
            return BurritoCore.API.Get<FeaturesResults>(_globals.RootURL + $"classes/{index}/features");
        }

        ///<summary>
        ///Gets the features available for a given class.
        ///</summary>
        public static Task GetFeaturesForClassAsync(BurritoCore.APICallReturnDelegate<FeaturesResults> callback, string index = "")
        {
            return BurritoCore.API.GetAsync<FeaturesResults>(_globals.RootURL + $"classes/{index}/features", callback);
        }

        ///<summary>
        ///Gets the proficiencies available for a given class.
        ///</summary>
        public static ProficienciesResults GetProficienciesForClassAsync(string index = "")
        {
            return BurritoCore.API.Get<ProficienciesResults>(_globals.RootURL + $"classes/{index}/proficiencies");
        }

        ///<summary>
        ///Gets the proficiencies available for a given class.
        ///</summary>
        public static Task GetProficienciesForClassAsync(BurritoCore.APICallReturnDelegate<ProficienciesResults> callback, string index = "")
        {
            return BurritoCore.API.GetAsync<ProficienciesResults>(_globals.RootURL + $"classes/{index}/proficiencies", callback);
        }

        ///<summary>
        ///Gets the level information for a given class.
        ///</summary>
        public static List<LevelsResults_> GetLevelsForClassAsync(string index = "")
        {
            return BurritoCore.API.Get<List<LevelsResults_>>(_globals.RootURL + $"classes/{index}/levels");
        }

        ///<summary>
        ///Gets the level information for a given class.
        ///</summary>
        public static Task GetLevelsForClassAsync(BurritoCore.APICallReturnDelegate<List<LevelsResults_>> callback, string index = "")
        {
            return BurritoCore.API.GetAsync<List<LevelsResults_>>(_globals.RootURL + $"classes/{index}/levels", callback);
        }

        ///<summary>
        ///Gets the information for a single level for a given class.
        ///</summary>
        public static Level_ GetLevelForClassAsync(string index = "", string level = "")
        {
            return BurritoCore.API.Get<Level_>(_globals.RootURL + $"classes/{index}/levels/{level}");
        }

        ///<summary>
        ///Gets the information for a single level for a given class.
        ///</summary>
        public static Task GetLevelForClassAsync(BurritoCore.APICallReturnDelegate<Level_> callback, string index = "", string level = "")
        {
            return BurritoCore.API.GetAsync<Level_>(_globals.RootURL + $"classes/{index}/levels/{level}", callback);
        }

        ///<summary>
        ///Gets the feature information for a single level for a given class.
        ///</summary>
        public static LevelFeatures GetLevelFeaturesForClassAsync(string index = "", string level = "")
        {
            return BurritoCore.API.Get<LevelFeatures>(_globals.RootURL + $"classes/{index}/levels/{level}/features");
        }

        ///<summary>
        ///Gets the feature information for a single level for a given class.
        ///</summary>
        public static Task GetLevelFeaturesForClassAsync(BurritoCore.APICallReturnDelegate<LevelFeatures> callback, string index = "", string level = "")
        {
            return BurritoCore.API.GetAsync<LevelFeatures>(_globals.RootURL + $"classes/{index}/levels/{level}/features", callback);
        }

        ///<summary>
        ///Gets the spell information for a single level for a given class.
        ///</summary>
        public static LevelSpells GetLevelSpellsForClassAsync(string index = "", string level = "")
        {
            return BurritoCore.API.Get<LevelSpells>(_globals.RootURL + $"classes/{index}/levels/{level}/spells");
        }

        ///<summary>
        ///Gets the spell information for a single level for a given class.
        ///</summary>
        public static Task GetLevelSpellsForClassAsync(BurritoCore.APICallReturnDelegate<LevelSpells> callback, string index = "", string level = "")
        {
            return BurritoCore.API.GetAsync<LevelSpells>(_globals.RootURL + $"classes/{index}/levels/{level}/spells", callback);
        }
    }
}