using System.Collections.Generic;

namespace MEABlite.core.Model
{
   public class Warband
   {
      public Warband()
      {
      }

      public int Id { get; set; }
      public string Name { get; set; }
      public string Notes { get; set; }
      public Hero WarbandLeader { get; set; }
      public List<Unit> Units { get; set; }
      public string ImagePath { get; set; }
   }
}