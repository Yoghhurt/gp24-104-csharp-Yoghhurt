class House
{
    public string Owner { get; set; }

    public House(string owner)
    {
        Owner = owner; // Initialize owner
    }

    public void PrintOwner()
    {
        Console.WriteLine($"This house is owned by {Owner}.");
    }
}