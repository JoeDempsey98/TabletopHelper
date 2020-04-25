using System;
using System.Collections.Generic;
using TabletopHelper.Characters.CharacterLibrary;
using TabletopHelper.Data.APIConnector;

namespace TabletopHelper.Characters.CharacterGenerator
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            //eventually clear out this area to further abstract
            //add further classes and/or projects to control further aspects, ie playable class management, inventory configuration, attack creation, etc.
            List<Weapon> Weapons = new List<Weapon>();

            var weaponList = GetEquipment.GetAllWeapons();
            foreach (var weapon in weaponList)
            {
                Weapon w = new Weapon();
                w.Name = weapon.Name;
                w.DamageDie = weapon.Damage.Damage_Dice;
                w.DamageType = weapon.Damage.Damage_Type.Name;
                w.Properties = new List<string>();
                foreach (var property in weapon.Properties)
                {
                    w.Properties.Add(property.Name);
                }
                Weapons.Add(w);
            }
            foreach (var w in Weapons)
            {
                Console.WriteLine(w.ToString());
            }
        }
    }
}
 