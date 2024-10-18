


using System.Net.Security;
using System.Reflection.Metadata.Ecma335;
using P3LevelUpp;

public class Program
{


   static void Main()
   {
      World world = new World();
      world.hello();
      Player first  = new Player();
      first.GrantExperience();
   }
   

   public class Player
   {
      public int level = 0;
      public int experience = 0;

      public void GrantExperience()
      {
         experience++; 
        string input = Console.ReadLine();
         int points = int.Parse(input);
         experience += points;

                 while (experience >= 100)
                 {
                    level++;
                    experience -= 100;
                 }

                 
                if (experience == 100)
                 {
                    level++;
                 }
         
         Console.WriteLine($"Level: {level}, Experience: {experience}");

      }


   }

}