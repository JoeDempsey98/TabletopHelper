using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using TabletopHelper.Data.APIConnector.Models;

namespace TabletopHelper.Data.APIConnector
{
    public static class GetEquipment
    {
        //include newtonsoft to convert from json string to parsable and queriable lists
        private static readonly string baseURL = "http://www.dnd5eapi.co";

        public static IList<WeaponModel> GetAllWeapons()
        {
            string content;

            using (HttpClient client = new HttpClient())
            {
                content = client.GetStringAsync(baseURL + "/api/equipment-categories/weapon").Result;
            }

            JObject allWeapons = JObject.Parse(content);
            IList<JToken> weapons = allWeapons["equipment"].Children().ToList();

            IList<WeaponModel> weaponList = new List<WeaponModel>();
            foreach (JToken weapon in weapons)
            {
                WeaponModel weaponModel = weapon.ToObject<WeaponModel>();
                using (HttpClient client = new HttpClient())
                {
                    weaponModel = JsonConvert.DeserializeObject<WeaponModel>(client.GetStringAsync(baseURL + weaponModel.URL).Result);
                }
                weaponList.Add(weaponModel);
            }


            return weaponList;
        }
        public static WeaponModel GetSearchedWeapon(string weaponName)
        {
            IList<WeaponModel> weapons = GetAllWeapons();
            foreach (var weapon in weapons)
            {
                if (weapon.Name == weaponName)
                    return weapon;
            }
            return null;
        }
    }
}
