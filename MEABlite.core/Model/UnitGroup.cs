using MEABlite.core.Model;
using System.Collections.Generic;

namespace MEABlite.core.Repository
{
   public class UnitGroup
   {
      public UnitGroup()
      {
      }

      public int UnitGroupId { get; set; }   
      public string Title { get; set; }
      public string ImagePath { get; set; }
      public List<Unit> Units { get; set; }
   }
}