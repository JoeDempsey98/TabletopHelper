using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CharacterLibrary;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TabletopHelper.Characters.CharacterLibrary;

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