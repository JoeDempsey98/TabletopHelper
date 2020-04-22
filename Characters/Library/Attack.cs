namespace TabletopHelper.Characters.CharacterLibrary
{
    //base structure for an attack
    public class Attack
    {
        public string AttackName { get; set; }
        public int AttackRollModifier { get; set; }
        public int DamageDieValue { get; set; }
        public int DamageModifier { get; set; }
        public string DamageType { get; set; }
        public bool IsCheckedSpell { get; set; }
        public int SaveDCValue { get; set; }
    }
}