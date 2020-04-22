using System.Collections.Generic;

namespace TabletopHelper.Characters.CharacterLibrary
{
    //base structure for a character
    public class Character
    {
        public string CharacterName { get; set; }
        public List<string> Classes { get; set; }
        public string Race { get; set; }
        public string Background { get; set; }
        public string Alignment { get; set; }
        public string PlayerName { get; set; }
        public int ExperiencePoints { get; set; }
        public List<AbilityScore> AbilityScores { get; set; }
        public bool Inspiration { get; set; }
        public int ProficiencyBonus { get; set; }
        public List<SavingThrow> SavingThrows { get; set; }
        public List<Skill> Skills { get; set; }
        public int ArmorClass { get; set; }
        public int Initiative { get; set; }
        public int Speed { get; set; }
        public HitPoints HitPoints { get; set; }
        public HitDice HitDice { get; set; }
        public DeathSaves DeathSaves { get; set; }
        public List<Attack> Attacks { get; set; }
        public List<Spell> Spells { get; set; }
        public List<string> Proficiencies { get; set; }
        public List<string> Languages { get; set; }
        public List<string> Features { get; set; }
        public List<string> Traits { get; set; }
        public List<string> Inventory { get; set; }
    }
}
