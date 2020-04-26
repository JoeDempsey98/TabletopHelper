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
                Attack attack = new Attack
                {
                    AttackName = weapon.Name,
                    DamageDieValue = Int32.Parse(weapon.DamageDie),
                    DamageType = weapon.DamageType
                };

                //look at weapon for the finesse property

                attacks.Add(attack);
            }

            return attacks;
        }
    }
}
