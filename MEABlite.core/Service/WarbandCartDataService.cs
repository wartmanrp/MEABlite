using MEABlite.core.Model;
using MEABlite.core.Repository;

namespace MEABlite.core.Service
{
   public class WarbandCartDataService
    {
      private static WarbandCartRepository warbandCart = new WarbandCartRepository();

      public WarbandCartDataService()
      {
      }

      public void AddWarband(Warband warband)
      {
         warbandCart.AddWarband(warband);
      }

      public WarbandCart GetCart()
      {
         return warbandCart.GetWarbandCart();
      }

    }
}
