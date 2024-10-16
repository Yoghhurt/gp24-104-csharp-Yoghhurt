
class Item
{
    public int GoldValue { get; set; }

    public Item(int goldValue)
    {
        GoldValue = goldValue;
    }
}

class Program
{
    static void Main(string[] args)
    {
        
        Item[] items = new Item[3];

        
        items[0] = new Item(100);
        items[1] = new Item(200);
        items[2] = new Item(300);

        
        for (int i = 0; i < items.Length; i++)
        {
            Console.WriteLine($"Item {i + 1} Gold Value: {items[i].GoldValue}");
        }
    }
}