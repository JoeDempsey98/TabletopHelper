using System;
using System.Collections.Generic;
using TabletopHelper.Characters.CharacterLibrary;

namespace TabletopHelper.Characters.CharacterGenerator
{
    public static class Generator
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
                Alignment = alignment
                //add ability score generator
                //add attack generator
                //add inventory creation
            };
        }
    }
}
