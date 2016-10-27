using MEABlite.core.Model;
using MEABlite.core.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MEABlite.core.Service
{
    public class ArmyListDataService
    {
      private static ArmyListRepository armyListRepository = new ArmyListRepository();

      public ArmyListDataService()
      {
      }

      public void AddWarband(Warband warband)
      {
         armyListRepository.AddWarband(warband);
      }

      public ArmyList GetArmyList()
      {
         return armyListRepository.GetList();
      }
        
    }
}
      