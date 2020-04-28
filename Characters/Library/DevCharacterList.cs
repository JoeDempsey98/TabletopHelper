using System;
using System.Collections.Generic;
using System.Text;
using TabletopHelper.Characters.CharacterLibrary;

namespace CharacterLibrary
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
                    Classes = new List<string> {"Barbarian"}
                },
                new Character()
                {
                    Id = 2, CharacterName = "Grom", PlayerName = "Sally", Race = "Elf",
                    Classes = new List<string> {"Wizard"}
                },
                new Character()
                {
                    Id = 3, CharacterName = "Radgar", PlayerName = "Kat", Race = "Dwarf",
                    Classes = new List<string> {"Paladin"}
                },
                new Character()
                {
                    Id = 4, CharacterName = "Artis", PlayerName = "John", Race = "Tiefling",
                    Classes = new List<string> {"Sorcerer"}
                }
            };
        }
        public IEnumerable<Character> GetAllCharacters()
        {
            return _characterList;
        }

        public Character GetCharacter(int id)
        {
            throw new NotImplementedException();
        }
    }
}
