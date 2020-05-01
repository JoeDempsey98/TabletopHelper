using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Runtime.InteropServices.WindowsRuntime;
using TabletopHelper.Characters.CharacterLibrary;
using TabletopHelper.Data.CharacterService;

namespace CharacterSite.Pages.Characters
{
    public class EditModel : PageModel
    {
        private readonly ICharacterList characterList;

        public EditModel(ICharacterList characterList)
        {
            this.characterList = characterList;
        }

        public Character Character { get; set; }
        public IActionResult OnGet(int id)
        {
            Character = characterList.GetCharacter(id);

            if (Character == null)
            {
                return RedirectToPage("/NotFound");
            }

            return Page();
        }
    }
}