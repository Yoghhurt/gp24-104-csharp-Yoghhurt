


class Program
{
   static void Main()
   {
      Player first  = new Player();
      first.GrantExperience(100);
   }
   

   public class Player
   {
      public int level;
      public int experience;

      public void GrantExperience()
      {
         experience++;
         if (experience >= 100)
         {
            level++;
            experience = 0;
         }

         Console.WriteLine($"Level: {level}, Experience: {experience}");

      }


   }

}
