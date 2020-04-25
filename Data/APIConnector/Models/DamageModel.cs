namespace TabletopHelper.Data.APIConnector.Models
{
    public class DamageModel
    {
        public string Damage_Dice { get; set; }
        public int Damage_Bonus { get; set; }
        public DamageTypeModel Damage_Type { get; set; }
    }
}