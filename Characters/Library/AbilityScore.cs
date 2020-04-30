namespace TabletopHelper.Characters.CharacterLibrary
{
    //base structure for an ability score
    public class AbilityScore
    {
        public int ScoreValue { get; set; }
        public int ScoreModifier { get { return (ScoreValue - 10) / 2; } }
    }
}