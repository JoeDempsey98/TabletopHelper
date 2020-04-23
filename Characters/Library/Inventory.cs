using System.Collections.Generic;

namespace TabletopHelper.Characters.CharacterLibrary
{
    public class Inventory
    {
        public List<Weapon> Weapons { get; set; }
        public List<Armor> Armors { get; set; }
        public List<string> Items { get; set; }
        public int Copper { get; set; }
        public int Silver { get; set; }
        public int Electrum { get; set; }
        public int Gold { get; set; }
        public int Platinum { get; set; }
    }
}