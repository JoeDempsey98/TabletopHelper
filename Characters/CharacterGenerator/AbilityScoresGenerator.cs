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

            return scores;
        }

        //add in different methods to generate random or pointbuy systems for ability scores
    }
}
