using MEABlite.core.Model;
using MEABlite.core.Repository;
using System.Collections.Generic;

namespace MEABlite.core.Service
{
   public class UnitDataService
    {
      private static UnitRepository unitRepository = new UnitRepository();

      public UnitDataService()
      {
      }

      public List<Unit> GetAllUnits()
      {
         return unitRepository.GetAllUnits();
      }

      public List<UnitGroup> GetGroupedUnits()
      {
         return unitRepository.GetGroupedUnits();
      }

      public List<Unit> GetUnitsForGroup(int unitGroupId)
      {
         return unitRepository.GetUnitsForGroup(unitGroupId);
      }

      public Unit GetUnitById(int unitId)
      {
         return unitRepository.GetUnitById(unitId);
      }
        
    }
}
