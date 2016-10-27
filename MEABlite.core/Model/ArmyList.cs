using System.Collections.Generic;

namespace MEABlite.core.Model
{
   public class ArmyList
    {
      public ArmyList()
      {
      }

      public int Id { get; set; }
      public string ArmyName { get; set; }
      public int PointsLimit { get; set; }
      public int ActualPoints { get; set; }
      public Hero Leader { get; set; }

      public int TotalModels { get; set; }
      public int ModelsWithBow { get; set; }
      public string ImagePath { get; set; }


      //collections for constructor
      public virtual List<Warband> Warbands { get; set; }
      public virtual List<Unit> IndependentUnit { get; set; }
         
   }
}
