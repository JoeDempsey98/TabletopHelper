using System;
using System.Collections.Generic;
using System.Text;
using TabletopHelper.Characters.CharacterLibrary;

namespace TabletopHelper.Characters.CharacterGenerator
{
    public static class AbilityScoresGenerator
    {
        public static AbilityScores Generate
            (int strength, int dexterity, int constitution, 
            int wisdom, int intelligence, int charisma)
        {
            AbilityScores scores = new AbilityScores();
            scores.Strength.ScoreValue = strength;
            scores.Dexterity.ScoreValue = dexterity;
            scores.Constitution.ScoreValue = constitution;
            scores.Wisdom.ScoreValue = wisdom;
            scores.Intelligence.ScoreValue = intelligence;
            scores.Charisma.ScoreValue = charisma;

            scores.Strength.ScoreModifier = (scores.Strength.ScoreValue - 10) / 2;
            scores.Dexterity.ScoreModifier = (scores.Dexterity.ScoreValue - 10) / 2;
            scores.Constitution.ScoreModifier = (scores.Constitution.ScoreValue - 10) / 2;
            scores.Wisdom.ScoreModifier = (scores.Wisdom.ScoreValue - 10) / 2;
            scores.Intelligence.ScoreModifier = (scores.Intelligence.ScoreValue - 10) / 2;
            scores.Charisma.ScoreModifier = (scores.Charisma.ScoreValue - 10) / 2;

            return scores;
        }

        //add in different methods to generate random or pointbuy systems for ability scores
    }
}
