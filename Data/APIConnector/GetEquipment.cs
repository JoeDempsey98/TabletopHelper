using System.Net.Http;

namespace TabletopHelper.Data.APIConnector
{
    public static class GetEquipment
    {
        //include newtonsoft to convert from json string to parsable and queriable lists
        private static string URL = "http://www.dnd5eapi.co/api/equipment-categories/weapon";

        public static string GetAllWeapons()
        {
            string content;

            using (HttpClient client = new HttpClient())
            {
                content = client.GetStringAsync(URL).Result;
            }
            return content;
        }
        public static string GetSearchedWeapon(string weaponName)
        {
            /* 
             * use newtonsoft to get the list of all weapons
             * and parse it for specific weapon type and use available returned url
             * to get further content 
             */
            string content = "";
            return content;
        }
    }
}
