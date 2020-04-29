using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TabletopHelper.Characters.CharacterLibrary;
using TabletopHelper.Data.CharacterService;

namespace CharacterSite.Pages.Characters
{
    public class IndexModel : PageModel
    {
        private readonly ICharacterList characterList;

        public IEnumerable<Character> Characters { get; set; }

        public IndexModel(ICharacterList characterList)
        {
            this.characterList = characterList;
        }
        public void OnGet()
        {
            Characters = characterList.GetAllCharacters();
        }
    }
}