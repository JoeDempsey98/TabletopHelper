using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TabletopHelper.Characters.CharacterLibrary;

namespace TabletopHelper.Data.ClassService
{
    public class DevClassList : IClassList
    {
        private List<Class> _classList;
        public DevClassList()
        {
            _classList = new List<Class>
            {
                new Class() { Id = 1, Name = "Barbarian" },
                new Class() { Id = 2, Name = "Bard" },
                new Class() { Id = 3, Name = "Cleric" },
                new Class() { Id = 4, Name = "Druid" },
                new Class() { Id = 5, Name = "Fighter" },
                new Class() { Id = 6, Name = "Monk" },
                new Class() { Id = 7, Name = "Paladin" },
                new Class() { Id = 8, Name = "Ranger" },
                new Class() { Id = 9, Name = "Rogue" },
                new Class() { Id = 10, Name = "Sorcerer" },
                new Class() { Id = 11, Name = "Warlock" },
                new Class() { Id = 12, Name = "Wizard" }
            };
        }
        public IEnumerable<Class> GetAllClasses()
        {
            return _classList;
        }

        public Class GetClass(int id)
        {
            return _classList.FirstOrDefault(c => c.Id == id);
        }
    }
}
