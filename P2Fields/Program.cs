

public class Player
{
    public string Name { get; set; }
    public string Email { get; set; }
    public int Gold { get; set; }
    public int Wood { get; set; }
    public int Stone { get; set; }
    public int Level { get; set; }
    public int Exp { get; set; }
    public bool Pvp { get; set; }
    public bool Vip { get; set; }


public Player(string name, string email, int gold, int stone, int wood, int level, int exp, bool vip, bool pvp)
    {
        Name = name;
        Email = email;
        Gold = gold;
        Stone = stone;
        Wood = wood;
        Level = level;
        Exp = exp;
        Vip = vip;
        Pvp = pvp;
    }

    public void PrintInfo()
    {
        Console.WriteLine($"Display Name: {Name}");
        Console.WriteLine($"Email: {Email}");
        Console.WriteLine($"Gold: {Gold}");
        Console.WriteLine($"Stone: {Stone}");
        Console.WriteLine($"Wood: {Wood}");
        Console.WriteLine($"Level: {Level}");
        Console.WriteLine($"Experience: {Exp}");
        Console.WriteLine($"VIP Status: {(Vip ? "Active" : "Inactive")}");
        Console.WriteLine($"PVP Status: {(Pvp ? "Enabled" : "Disabled")}");
    }
}
class Program{    
static void Main(string[] args)
{
    Player playerA = new Player(
        "Marc",
        "marc@zaku.de",
        200,
        110,
        53,
        12,
        123,
        true, 
        false 
    );

    
    playerA.PrintInfo();
}
}