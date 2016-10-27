namespace MEABlite.core.Model
{
   public class Hero : Unit
   {
      public Hero()
      {
      }

      public int Might { get; set; }
      public int Will { get; set; }
      public int Fate { get; set; }
      public bool IsLeader { get; set; }
      public string Notes { get; set; }
   }
}
