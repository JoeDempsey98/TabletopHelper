using System;
using System.Collections.Generic;
using System.Text;
using TabletopHelper.Characters.CharacterLibrary;

namespace TabletopHelper.Data.ClassService
{
    public interface IClassList
    {
        IEnumerable<Class> GetAllClasses();
    }
}
