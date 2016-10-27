namespace MEABlite.core.Model
{
   public class Unit
   {
      public Unit()
      {
      }

      public int UnitId { get; set; }
      public string Name { get; set; }
      public string UnitType { get; set; }
      public bool IsIndependent { get; set; }
      public bool HasBow { get; set; }
      public string Description { get; set; }
      public string ImagePath { get; set; }
      public int? Amount { get; set; }

      public int Points { get; set; }
      public int Fight { get; set; }
      public int Shoot { get; set; }
      public int Strength { get; set; }
      public int Defense { get; set; }
      public int Attacks { get; set; }
      public int Wounds { get; set; }
      public int Courage { get; set; }
   }
}
