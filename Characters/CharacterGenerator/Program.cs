using System;

namespace TabletopHelper.Characters.CharacterGenerator
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            //eventually clear out this area to further abstract
            //add further classes and/or projects to control further aspects, ie playable class management, inventory configuration, attack creation, etc.

            Console.WriteLine("Input Player Name: ");
            string playerName = Console.ReadLine();
            Console.WriteLine("Input Character Name: ");
            string characterName = Console.ReadLine();
            Console.WriteLine("Input Race: ");
            string race = Console.ReadLine();
            Console.WriteLine("Input Class: ");
            string className = Console.ReadLine();
            Console.WriteLine("Input Background: ");
            string background = Console.ReadLine();
            Console.WriteLine("Input Alignment: ");
            string alignment = Console.ReadLine();
            Console.WriteLine("Input Strength: ");
            int strength = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Input Dexterity: ");
            int dexterity = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Input Constitution: ");
            int constitution = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Input Wisdom: ");
            int wisdom = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Input Intelligence: ");
            int intelligence = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Input Charisma: ");
            int charisma = Int32.Parse(Console.ReadLine());

            var character = Generator.GenerateNewCharacter
                (characterName, playerName, race, 
                className, background, alignment,
                strength, dexterity, constitution,
                wisdom, intelligence, charisma);

            Console.WriteLine("Modifiers:");
            foreach(var i in character.AbilityScores)
            {
                Console.WriteLine("{0}: {1}, {2}", i.ScoreName, i.ScoreValue, i.ScoreModifier);
            }
        }
    }
}
 