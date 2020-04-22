namespace TabletopHelper.Characters.CharacterLibrary
{
    //base structure for saving throws
    public class SavingThrow
    {
        public string SavingThrowName { get; set; }
        public bool Proficiency { get; set; }
        public AbilityScore BaseAbility { get; set; }
        public int Modifier { get; set; }
    }
}