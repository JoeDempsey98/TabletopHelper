using System;
using System.Collections.Generic;
using System.Text;
using TabletopHelper.Characters.CharacterLibrary;

namespace TabletopHelper.Characters.CharacterGenerator
{
    public static class AttacksGenerator
    {
        public static List<Attack> GenerateAttacks(Character character)
        {
            var weapons = character.Inventory.Weapons;
            List<Attack> attacks = new List<Attack>();

            foreach (var weapon in weapons)
            {
                Attack attack = new Attack();
                attack.AttackName = weapon.Name;
                attack.DamageDieValue = weapon.DamageDie;
                attack.DamageType = weapon.DamageType;
                if (weapon.IsFinesse)
                {
                    attack.AttackRollModifier = character.AbilityScores.Dexterity.ScoreModifier;
                }
                else
                {
                    attack.AttackRollModifier = character.AbilityScores.Strength.ScoreModifier;
                }
                attacks.Add(attack);
            }

            return attacks;
        }
    }
}
