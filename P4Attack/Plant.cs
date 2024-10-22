class Plant
{
    private bool isGrown;

    public Plant()
    {
        isGrown = false; // Initialize as a seed
    }

    public void PrintStatus()
    {
        if (isGrown)
        {
            Console.WriteLine("Plant is a tree.");
        }
        else
        {
            Console.WriteLine("Plant is a seed.");
        }
    }

    public void Grow()
    {
        Console.WriteLine("Plant is growing.");
        isGrown = true; // Change state to grown
    }
}