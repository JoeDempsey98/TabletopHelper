using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System.Linq;
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

        [BindProperty]
        public Character Character { get; set; }
        public List<Class> Classes { get; set; }
        [BindProperty]
        public List<int> SelectedClassIds { get; set; }
        public IActionResult OnGet(int id)
        {
            Character = characterList.GetCharacter(id);
            
            if (Character == null)
            {
                return RedirectToPage("/NotFound");
            }

            Classes = classList.GetAllClasses().ToList();
            SelectedClassIds = new List<int>();
            foreach(var c in Character.Classes)
            {
                SelectedClassIds.Add(c.Id);
            }

            return Page();
        }

        public IActionResult OnPost()
        {
            Character.Classes = new List<Class>();
            foreach(var c in SelectedClassIds)
            {
                Character.Classes.Add(classList.GetClass(c));
            }
            Character = characterList.Update(Character);
            return RedirectToPage("Index");
        }
    }
}