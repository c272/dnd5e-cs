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
    ///The Character class, rolled up by Burrito.
    ///</summary>
    public class Character
    {
        ///<summary>
        ///Gets a list of ability scores matching a given name (or none at all!)
        ///</summary>
        public static AbilitySearchResults SearchAbilitiesAsync(string name = "")
        {
            return BurritoCore.API.Get<AbilitySearchResults>(_globals.RootURL + $"ability-scores?name={name}");
        }

        ///<summary>
        ///Gets a list of ability scores matching a given name (or none at all!)
        ///</summary>
        public static Task SearchAbilitiesAsync(BurritoCore.APICallReturnDelegate<AbilitySearchResults> callback, string name = "")
        {
            return BurritoCore.API.GetAsync<AbilitySearchResults>(_globals.RootURL + $"ability-scores?name={name}", callback);
        }

        ///<summary>
        ///Gets a specific ability, given an ability index.
        ///</summary>
        public static Ability GetAbilityAsync(string index = "")
        {
            return BurritoCore.API.Get<Ability>(_globals.RootURL + $"ability-scores/{index}");
        }

        ///<summary>
        ///Gets a specific ability, given an ability index.
        ///</summary>
        public static Task GetAbilityAsync(BurritoCore.APICallReturnDelegate<Ability> callback, string index = "")
        {
            return BurritoCore.API.GetAsync<Ability>(_globals.RootURL + $"ability-scores/{index}", callback);
        }

        ///<summary>
        ///Gets a list of skills matching a given name (or none at all!)
        ///</summary>
        public static SkillSearchResults SearchSkillsAsync(string name = "")
        {
            return BurritoCore.API.Get<SkillSearchResults>(_globals.RootURL + $"skills?name={name}");
        }

        ///<summary>
        ///Gets a list of skills matching a given name (or none at all!)
        ///</summary>
        public static Task SearchSkillsAsync(BurritoCore.APICallReturnDelegate<SkillSearchResults> callback, string name = "")
        {
            return BurritoCore.API.GetAsync<SkillSearchResults>(_globals.RootURL + $"skills?name={name}", callback);
        }

        ///<summary>
        ///Gets a specific skill, given a skill index.
        ///</summary>
        public static Skill GetSkillAsync(string index = "")
        {
            return BurritoCore.API.Get<Skill>(_globals.RootURL + $"skills/{index}");
        }

        ///<summary>
        ///Gets a specific skill, given a skill index.
        ///</summary>
        public static Task GetSkillAsync(BurritoCore.APICallReturnDelegate<Skill> callback, string index = "")
        {
            return BurritoCore.API.GetAsync<Skill>(_globals.RootURL + $"skills/{index}", callback);
        }

        ///<summary>
        ///Gets a list of proficiencies matching a given name (or none at all!)
        ///</summary>
        public static ProficencySearchResults SearchProficienciesAsync(string name = "", string type = "")
        {
            return BurritoCore.API.Get<ProficencySearchResults>(_globals.RootURL + $"proficiencies?name={name}&type={type}");
        }

        ///<summary>
        ///Gets a list of proficiencies matching a given name (or none at all!)
        ///</summary>
        public static Task SearchProficienciesAsync(BurritoCore.APICallReturnDelegate<ProficencySearchResults> callback, string name = "", string type = "")
        {
            return BurritoCore.API.GetAsync<ProficencySearchResults>(_globals.RootURL + $"proficiencies?name={name}&type={type}", callback);
        }

        ///<summary>
        ///Gets a specific proficiency, given a proficiency index.
        ///</summary>
        public static Proficiency GetProficiencyAsync(string index = "")
        {
            return BurritoCore.API.Get<Proficiency>(_globals.RootURL + $"proficiencies/{index}");
        }

        ///<summary>
        ///Gets a specific proficiency, given a proficiency index.
        ///</summary>
        public static Task GetProficiencyAsync(BurritoCore.APICallReturnDelegate<Proficiency> callback, string index = "")
        {
            return BurritoCore.API.GetAsync<Proficiency>(_globals.RootURL + $"proficiencies/{index}", callback);
        }

        ///<summary>
        ///Gets a list of languages matching a given name (or none at all!)
        ///</summary>
        public static LanguageSearchResults SearchLanguagesAsync(string name = "", string type = "")
        {
            return BurritoCore.API.Get<LanguageSearchResults>(_globals.RootURL + $"languages?name={name}&type={type}");
        }

        ///<summary>
        ///Gets a list of languages matching a given name (or none at all!)
        ///</summary>
        public static Task SearchLanguagesAsync(BurritoCore.APICallReturnDelegate<LanguageSearchResults> callback, string name = "", string type = "")
        {
            return BurritoCore.API.GetAsync<LanguageSearchResults>(_globals.RootURL + $"languages?name={name}&type={type}", callback);
        }

        ///<summary>
        ///Gets a specific language, given a language index.
        ///</summary>
        public static Language GetLanguageAsync(string index = "")
        {
            return BurritoCore.API.Get<Language>(_globals.RootURL + $"languages/{index}");
        }

        ///<summary>
        ///Gets a specific language, given a language index.
        ///</summary>
        public static Task GetLanguageAsync(BurritoCore.APICallReturnDelegate<Language> callback, string index = "")
        {
            return BurritoCore.API.GetAsync<Language>(_globals.RootURL + $"languages/{index}", callback);
        }
    }
}