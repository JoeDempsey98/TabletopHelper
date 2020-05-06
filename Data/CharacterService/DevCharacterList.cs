using TabletopHelper.Characters.CharacterLibrary;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel;

namespace TabletopHelper.Data.CharacterService
{
    public class DevCharacterList : ICharacterList
    {
        private List<Character> _characterList;
        public DevCharacterList()
        {
            _characterList = new List<Character>()
            {
                new Character()
                {
                    Id = 1, CharacterName = "Bob", PlayerName = "Jim", Race = "Human",
                    Classes = new List<Class> { new Class { Name = "Barbarian", Id = 1 } } , Background = "Noble", Alignment = "LG",
                    AbilityScores = new AbilityScores
                    {
                        Strength = new AbilityScore {ScoreValue = 19},
                        Dexterity = new AbilityScore {ScoreValue = 17},
                        Constitution = new AbilityScore {ScoreValue = 16},
                        Wisdom = new AbilityScore {ScoreValue = 13},
                        Intelligence = new AbilityScore {ScoreValue = 10},
                        Charisma = new AbilityScore {ScoreValue = 8}
                    },
                    HitPoints = new HitPoints {MaximumHealth = 14, CurrentHealth = 14},
                    Features = new List<string> {"Cool dude", "Attack gud"}
                },
                new Character()
                {
                    Id = 2, CharacterName = "Grom", PlayerName = "Sally", Race = "Elf",
                    Classes = new List<Class> { new Class { Name = "Wizard" } }
                },
                new Character()
                {
                    Id = 3, CharacterName = "Radgar", PlayerName = "Kat", Race = "Dwarf",
                    Classes = new List<Class> { new Class { Name = "Paladin" } }
                },
                new Character()
                {
                    Id = 4, CharacterName = "Artis", PlayerName = "John", Race = "Tiefling",
                    Classes = new List<Class> { new Class { Name = "Sorcerer"} } 
                }
            };
        }
        public IEnumerable<Character> GetAllCharacters()
        {
            return _characterList;
        }

        public Character GetCharacter(int id)
        {
            return _characterList.FirstOrDefault(c => c.Id == id);
        }

        public Character Update(Character updatedCharacter)
        {
            Character character = _characterList.FirstOrDefault(c => c.Id == updatedCharacter.Id);

            if (character != null)
            {
                character.AbilityScores = updatedCharacter.AbilityScores;
                character.Alignment = updatedCharacter.Alignment;
                character.Background = updatedCharacter.Background;
                character.CharacterName = updatedCharacter.CharacterName;
                character.Classes = updatedCharacter.Classes;
                character.ExperiencePoints = updatedCharacter.ExperiencePoints;
                character.HitPoints = updatedCharacter.HitPoints;
                character.Inspiration = updatedCharacter.Inspiration;
                character.Inventory = updatedCharacter.Inventory;
                character.Languages = updatedCharacter.Languages;
                character.PlayerName = updatedCharacter.PlayerName;
                character.Proficiencies = updatedCharacter.Proficiencies;
                character.Race = updatedCharacter.Race;
                character.Skills = updatedCharacter.Skills;
                character.Spells = updatedCharacter.Spells;
            }

            return character;
        }
    }
}
