using MEABlite.core.Model;
using System.Collections.Generic;
using System.Linq;

namespace MEABlite.core.Repository
{
   public class UnitRepository
    {
      public UnitRepository()
      {
      }

      public List<Unit> GetAllUnits()
      {
         IEnumerable<Unit> units = 
         unitGroups
         .SelectMany(x => x.Units);
         return units.ToList();
      }

      public List<UnitGroup> GetGroupedUnits()
      {
         return unitGroups;
      }

      public List<Unit> GetUnitsForGroup(int unitGroupId)
      {
         var group = unitGroups
            .Where(h => h.UnitGroupId == unitGroupId)
            .FirstOrDefault();

         if (group != null)
         {
            return group.Units;
         }
         return null;
      }

      public Unit GetUnitById(int unitId)
      {
         IEnumerable<Unit> unit =
         unitGroups
         .SelectMany(x => x.Units
         .Where(u => u.UnitId == unitId));

         return unit.FirstOrDefault();
      }

      private static List<UnitGroup> unitGroups = new List<UnitGroup>()
      {
         new UnitGroup()
         {
            UnitGroupId = 1, Title = "Infantry", ImagePath = "", Units = new List<Unit>()
            {
               new Unit()
               {
                  UnitId = 1
                  , Name = "Ranger of Gondor"
                  , UnitType = "Man"
                  , IsIndependent = false
                  , HasBow = true
                  , Description = "The quaff bore this his many linking head again there-"
                  , ImagePath = ""
                  , Points = 8
                  , Fight = 4
                  , Shoot = 3
                  , Strength = 3
                  , Defense = 4
                  , Attacks = 1
                  , Wounds = 1
                  , Courage = 3
               },
               new Unit()
               {
                  UnitId = 2
                  , Name = "Warrior of Minas Tirith"
                  , UnitType = "Man"
                  , IsIndependent = false
                  , HasBow = false
                  , Description = "More expressing door scarcely his curious and of came whom flitting soul thereat deep i one entreating bust syllable then"
                  , ImagePath = ""
                  , Points = 9
                  , Fight = 3
                  , Shoot = 4
                  , Strength = 3
                  , Defense = 6
                  , Attacks = 1
                  , Wounds = 1
                  , Courage = 3
               },
               new Unit()
               {
                  UnitId = 3
                  , Name = "Guard of the Fountain Court"
                  , UnitType = "Man"
                  , IsIndependent = false
                  , HasBow = false
                  , Description = "Streaming dreaming forgiveness quoth ever my hath for from fact seraphim god the a surely"
                  , ImagePath = ""
                  , Points = 11
                  , Fight = 4
                  , Shoot = 4
                  , Strength = 3
                  , Defense = 7
                  , Attacks = 1
                  , Wounds = 1
                  , Courage = 4
               },
               new Unit()
               {
                  UnitId = 4
                  , Name = "Osgiliath Veteran"
                  , UnitType = "Man"
                  , IsIndependent = false
                  , HasBow = false
                  , Description = "The made me i and and mien word desolate shadow the the above till quoth this of raven hope with"
                  , ImagePath = ""
                  , Points = 9
                  , Fight = 4
                  , Shoot = 4
                  , Strength = 3
                  , Defense = 6
                  , Attacks = 1
                  , Wounds = 1
                  , Courage = 4
               }
            }
         },
         new UnitGroup()
         {
            UnitGroupId = 2, Title = "Heroes", ImagePath = "", Units = new List<Unit>()
            {
               new Hero()
               {
                  UnitId = 5
                  , Name = "Captain of Gondor"
                  , UnitType = "Man"
                  , IsIndependent = false
                  , HasBow = false
                  , Description = "This name and rapping melancholy no grim straight maiden this"
                  , ImagePath = ""
                  , Points = 55
                  , Fight = 4
                  , Shoot = 3
                  , Strength = 4
                  , Defense = 7
                  , Attacks = 2
                  , Wounds = 2
                  , Courage = 4
                  , Might = 2
                  , Will = 1
                  , Fate = 1
                  , IsLeader = false
                  , Notes = "In discourse just that take came i i yore nothing least the into see nightly more a than and laden scarce engaged name thy entrance heart eyes being wrought my"
               },
               new Hero()
               {
                  UnitId = 6
                  , Name = "Denethor"
                  , UnitType = "Man"
                  , IsIndependent = false
                  , HasBow = false
                  , Description = "Lining i burden while the entreating of discourse i upon i yore the sat gloating floor my radiant or many black oer such"
                  , ImagePath = ""
                  , Points = 30
                  , Fight = 5
                  , Shoot = 4
                  , Strength = 4
                  , Defense = 6
                  , Attacks = 2
                  , Wounds = 2
                  , Courage = 5
                  , Might = 1
                  , Will = 3
                  , Fate = 1
                  , IsLeader = true
                  , Notes = "In discourse just that take came i i yore nothing least the into see nightly more a than and laden scarce engaged name thy entrance heart eyes being wrought my"
               }
            }
         },
         new UnitGroup()
         {
            UnitGroupId = 3, Title = "Cavalry", ImagePath = "", Units = new List<Unit>()
            {
               new Unit()
               {
                  UnitId = 7
                  , Name = "Knight of Minas Tirith"
                  , UnitType = "Man/Horse"
                  , IsIndependent = false
                  , HasBow = false
                  , Description = "Nodded the bird velvet that and just name books and"
                  , ImagePath = ""
                  , Points = 14
                  , Fight = 3
                  , Shoot = 4
                  , Strength = 3 
                  , Defense = 6
                  , Attacks = 1
                  , Wounds = 1
                  , Courage = 3
               }
            }
         },
      };
    }
}
