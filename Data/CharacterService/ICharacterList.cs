using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using TabletopHelper.Characters.CharacterLibrary;

namespace TabletopHelper.Data.CharacterService
{
    public interface ICharacterList
    {
        IEnumerable<Character> GetAllCharacters();
        Character GetCharacter(int id);
        Character Update(Character updatedCharacter);
    }
}
