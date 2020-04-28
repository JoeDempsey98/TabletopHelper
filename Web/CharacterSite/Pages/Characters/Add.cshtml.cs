using CharacterLibrary;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TabletopHelper.Characters.CharacterLibrary;

namespace CharacterSite.Pages.Characters
{
    public class AddModel : PageModel
    {
        private readonly ICharacterList characterList;

        public AddModel(ICharacterList characterList)
        {
            this.characterList = characterList;
        }

        public Character Character { get; set; }

        //inject class for creating characters, and uploading them to database/cloud
        public void OnGet()
        {

        }
    }
}