namespace P3LevelUpp;

public class Person
{
    public string Name { get; set; }
    
    public Person(string name)
    {
        Name = name;
    }
    
    public void Greeting()
    {
        Console.WriteLine($"Hello {Name}!");
    }
}