


using System.Net.Security;
using System.Reflection.Metadata.Ecma335;
using P3LevelUpp;

public class Program
{


   static void Main()
   {
      World world = new World();
      world.hello();
      Person[] people = new Person[3];
      
      for (int i = 0; i < people.Length; i++)
      {
         Console.Write($"Enter the name for person {i + 1}: ");
         string name = Console.ReadLine();
         people[i] = new Person(name);
      }
      
      foreach (var person in people)
      {
         person.Greeting();
      }
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