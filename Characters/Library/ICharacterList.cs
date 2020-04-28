using System.Collections.Generic;
using TabletopHelper.Characters.CharacterLibrary;

namespace CharacterLibrary
{
    public interface ICharacterList
    {
        IEnumerable<Character> GetAllCharacters();
        Character GetCharacter(int id);
    }
}
