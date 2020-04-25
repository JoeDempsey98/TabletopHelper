using System.Collections.Generic;

namespace TabletopHelper.Characters.CharacterLibrary
{
    public class Weapon
    {
        public string Name { get; set; }
        public string DamageDie { get; set; }
        public string DamageType { get; set; }
        public List<string> Properties { get; set; }
        public override string ToString()
        {
            string properties = "";
            foreach (string i in Properties)
            {
                properties = properties + i + " ";
            }

            string content = Name + ", " + DamageDie + ", " + DamageType + ", " + properties;
            return content;
        }
    }
}