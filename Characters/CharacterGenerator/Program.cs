using System;
using System.Linq;

namespace TabletopHelper.Characters.CharacterGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            //test 
            var character = Generator.GenerateNewCharacter();
            Console.WriteLine("Name: " + character.CharacterName);
            Console.WriteLine("Player Name: " + character.PlayerName);
            Console.WriteLine("HP: " + character.HitPoints.CurrentHealth);
            Console.WriteLine("Race: " + character.Race);
            Console.WriteLine("Class: " + character.Classes.First());
            Console.WriteLine("AC: " + character.ArmorClass);
            Console.WriteLine("Background: " + character.Background);
            Console.WriteLine("Alignment: " + character.Alignment);
        }
    }
}
