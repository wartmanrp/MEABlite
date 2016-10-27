using MEABlite.core.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MEABlite.core.Repository
{
    public class ArmyListRepository
    {
      public ArmyListRepository()
      {         
      }

      static ArmyList MainList = new ArmyList() { Warbands = new List<Warband>() };

      public void AddWarband(Warband warBand)
      {
         MainList.Warbands.Add(warBand);
      }

      public ArmyList GetList()
      {
         return MainList;
      }
   }
}
