using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System.Runtime.InteropServices.WindowsRuntime;
using TabletopHelper.Characters.CharacterLibrary;
using TabletopHelper.Data.CharacterService;
using TabletopHelper.Data.ClassService;

namespace CharacterSite.Pages.Characters
{
    public class EditModel : PageModel
    {
        private readonly ICharacterList characterList;
        private readonly IClassList classList;

        public EditModel(ICharacterList characterList, IClassList classList)
        {
            this.characterList = characterList;
            this.classList = classList;
        }

        public Character Character { get; set; }
        public SelectList Options { get; set; }
        public List<int> SelectedOptions { get; set; }
        public IActionResult OnGet(int id)
        {
            Character = characterList.GetCharacter(id);
            
            if (Character == null)
            {
                return RedirectToPage("/NotFound");
            }

            Options = new SelectList(classList.GetAllClasses(), nameof(Class.Id), nameof(Class.Name));

            SelectedOptions = new List<int>();
            foreach (var c in Character.Classes)
            {
                SelectedOptions.Add(c.Id);
            }

            return Page();
        }
    }
}