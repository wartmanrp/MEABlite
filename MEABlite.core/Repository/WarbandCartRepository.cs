using MEABlite.core.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MEABlite.core.Repository
{
    public class WarbandCartRepository
    {
      public WarbandCartRepository()
      {
      }

      static WarbandCart WarbandCart = new WarbandCart() { Warbands = new List<Warband>() };

      public void AddWarband(Warband warBand)
      {
         WarbandCart.Warbands.Add(new Warband() {
            Id = warBand.Id
            , ImagePath = warBand.ImagePath
            , Name = warBand.Name
            , Notes = warBand.Notes
            , Units = warBand.Units
            , WarbandLeader = warBand.WarbandLeader
         });

         //WarbandCart.Warbands.Add(warBand);
      }

      public WarbandCart GetWarbandCart()
      {
         return WarbandCart;
      }

    }
}
