using System.Reflection.Metadata.Ecma335;

namespace TabletopHelper.Characters.Library
{
    //base structure for skills
    public class Skill
    {
        public string SkillName { get; set; }
        public bool Proficiency { get; set; }
        public AbilityScore BaseAbility { get; set; }
        public int Modifier { get; set; }
    }
}