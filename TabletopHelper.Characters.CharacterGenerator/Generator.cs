using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using TabletopHelper.Characters.Library;

namespace TabletopHelper.Characters.CharacterGenerator
{
    public static class Generator
    {
        //allow for values to be assigned to generate characters
        public static Character GenerateNewCharacter()
        {
            //test values to be abstrated later
            Character newCharacter = new Character
            {
                CharacterName = "Test Character",
                PlayerName = "Test Player",
                Race = "Human",
                Background = "Noble",
                Alignment = "LG",
                Classes = new List<string> { "Barbarian" },
                AbilityScores = new List<AbilityScore>
                {
                    new AbilityScore { ScoreName = "Strength", ScoreValue = 10, ScoreModifier = 0 },
                    new AbilityScore { ScoreName = "Dexterity", ScoreValue = 10, ScoreModifier = 0 },
                    new AbilityScore { ScoreName = "Constitution", ScoreValue = 10, ScoreModifier = 0 },
                    new AbilityScore { ScoreName = "Wisdom", ScoreValue = 10, ScoreModifier = 0 },
                    new AbilityScore { ScoreName = "Intelligence", ScoreValue = 10, ScoreModifier = 0 },
                    new AbilityScore { ScoreName = "Charisma", ScoreValue = 10, ScoreModifier = 0 }
                },
                ArmorClass = 10,
                ExperiencePoints = 0,
                HitPoints = new HitPoints
                {
                    MaximumHealth = 10,
                    CurrentHealth = 10,
                    TemporaryHealth = 0
                },
                Initiative = 0,
                
            };

            return newCharacter;
        }
    }
}
