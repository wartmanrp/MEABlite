using MEABlite.core.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MEABlite.core.Repository
{
    public class WarbandRepository
    {
      public WarbandRepository()
      {
      }

      static Warband MainWarband = new Warband() { Units = new List<Unit>() };

      public void AddUnit(Unit unit, int amount)
      {
         MainWarband.Units.Add(unit);
      }

      public Warband GetWarband()
      {
         return MainWarband;
      }
    }
}
