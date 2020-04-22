using System.Collections.Generic;

namespace TabletopHelper.Characters.CharacterLibrary
{
    //base structure for spells
    public class Spell
    {
        public string SpellName { get; set; }
        public string SpellSchool { get; set; }
        public List<string> SpellComponents { get; set; }
        public string SpellDescription { get; set; }
    }
}