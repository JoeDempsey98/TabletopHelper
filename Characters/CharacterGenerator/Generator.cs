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
                Alignment = alignment,
                AbilityScores = new List<AbilityScore>
                {
                    new AbilityScore{ScoreName = "Strength", ScoreValue = strength, ScoreModifier = Convert.ToInt32(Math.Floor((strength - 10) / 2f))},
                    new AbilityScore{ScoreName = "Dexterity", ScoreValue = dexterity, ScoreModifier = Convert.ToInt32(Math.Floor((dexterity - 10) / 2f))},
                    new AbilityScore{ScoreName = "Constitution", ScoreValue = constitution, ScoreModifier = Convert.ToInt32(Math.Floor((constitution - 10) / 2f))},
                    new AbilityScore{ScoreName = "Wisdom", ScoreValue = wisdom, ScoreModifier = Convert.ToInt32(Math.Floor((wisdom - 10) / 2f))},
                    new AbilityScore{ScoreName = "Intelligence", ScoreValue = intelligence, ScoreModifier = Convert.ToInt32(Math.Floor((intelligence - 10) / 2f))},
                    new AbilityScore{ScoreName = "Charisma", ScoreValue = charisma, ScoreModifier = Convert.ToInt32(Math.Floor((charisma - 10) / 2f))}
                }
            };
        }
    }
}
