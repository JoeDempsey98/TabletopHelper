using Microsoft.AspNetCore.Mvc.RazorPages;
using TabletopHelper.Characters.CharacterLibrary;
using TabletopHelper.Data.CharacterService;

namespace CharacterSite.Pages.Characters
{
    public class DetailsModel : PageModel
    {
        private readonly ICharacterList characterList;

        public DetailsModel(ICharacterList characterList)
        {
            this.characterList = characterList;
        }

        public Character Character { get; private set; }

        public void OnGet(int id)
        {
            Character = characterList.GetCharacter(id);
        }
    }
}