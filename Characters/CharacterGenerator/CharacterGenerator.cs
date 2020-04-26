using System;
using System.Collections.Generic;
using TabletopHelper.Characters.CharacterLibrary;

namespace TabletopHelper.Characters.CharacterGenerator
{
    public static class CharacterGenerator
    {
        //add in further methods to allow for customization in the character generation process

        //allows for a minimal amount of info to create a character
        public static Character GenerateNewCharacter
            (string characterName, string playerName, string race, 
            string className, string background, string alignment,
            int strength, int dexterity, int constitution,
            int wisdom, int intelligence, int charisma)
        {
            return new Character
            {
                CharacterName = characterName,
                PlayerName = playerName,
                Race = race,
                Classes = new List<string> { className },
                Background = background,
                Alignment = alignment,
                AbilityScores = AbilityScoresGenerator.Generate(strength, dexterity, constitution, wisdom, intelligence, charisma)

                //add attack generator
                //add inventory creation
            };
        }

        /*
         * Add a method that generates a character as follows:
         * 1. Get player name and character name
         * 2. Get race, class, and levels
         * 3. Get ability scores
         * 4. Get character background, alignment
         * 5. Get starting equipment
         */
    }
}
