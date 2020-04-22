namespace TabletopHelper.Characters.CharacterLibrary
{
    //base structure for an ability score
    public class AbilityScore
    {
        public string ScoreName { get; set; }
        public int ScoreValue { get; set; }
        public int ScoreModifier { get; set; }
    }
}