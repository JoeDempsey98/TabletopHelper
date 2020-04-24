using System;
using TabletopHelper.Data.APIConnector;

namespace TabletopHelper.Characters.CharacterGenerator
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            //eventually clear out this area to further abstract
            //add further classes and/or projects to control further aspects, ie playable class management, inventory configuration, attack creation, etc.
            Console.WriteLine(GetEquipment.GetAllWeapons());
        }
    }
}
 