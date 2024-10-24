class Item { }

class LivingBeing : Item { }

class Food : Item { }

class Weapon : Item { }

class Animal : LivingBeing { }

class Fruit : Food { }

class Bread : Food { }

class Banana : Fruit { }

class Apple : Fruit { }

class Pear : Fruit { }

class Sword : Weapon { }

class Axe : Weapon { }

class Pencil : Item { }

class Shield : Weapon { }

class Spear : Weapon { }

class Tree : LivingBeing { }

class Gorilla : Animal { }

class Chimpanzee : Animal { }

class Sparrow : Animal { }

class Pigeon : Animal { }

class Hawk : Animal { }


class DarthVader
{
    public string Name { get; set; } = "Darth Vader";
    public string Title { get; set; } = "Sith Lord";

    

    public void ShowTitle()
    {
        Console.WriteLine($"{Name} is known as the {Title}.");
    }
}


class Luke : DarthVader
{
    
    
}


class Program
{
    static void Main(string[] args)
    {
        DarthVader vader = new DarthVader();
        vader.ShowTitle();
        

        Luke luke = new Luke();
        luke.ShowTitle(); 
        
    }
}
