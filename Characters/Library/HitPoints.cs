namespace TabletopHelper.Characters.Library
{
    //base structure for hit points
    public class HitPoints
    {
        public int MaximumHealth { get; set; }
        public int CurrentHealth { get; set; }
        public int TemporaryHealth { get; set; }
    }
}