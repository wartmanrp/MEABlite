using MEABlite.core.Model;
using MEABlite.core.Repository;

namespace MEABlite.core.Service
{
   public class WarbandDataService
    {
      private static WarbandRepository warbandRepository = new WarbandRepository();

      public WarbandDataService()
      {
      }

      public void AddUnit(Unit unit, int amount)
      {
         warbandRepository.AddUnit(unit, amount);
      }

      public Warband GetWarband()
      {
         return warbandRepository.GetWarband();
      }
    }
}
