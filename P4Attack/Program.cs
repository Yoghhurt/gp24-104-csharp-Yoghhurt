


class Program
{
    static void Main(string[] args)
    {
        Player player1 = new Player();
        Player player2 = new Player();

        player1.Attack(player2);
        Console.WriteLine($"Player1 Damage: {player1.Damage}, Player2 Damage: {player2.Damage}");

        player2.Attack(player1);
        Console.WriteLine($"Player1 Damage: {player1.Damage}, Player2 Damage: {player2.Damage}");

        player1.Attack(player1);
        Console.WriteLine($"Player1 Damage: {player1.Damage}, Player2 Damage: {player2.Damage}");


        Player player3 = player1;

        player2.Attack(player3);
        Console.WriteLine(
            $"Player1 Damage: {player1.Damage}, Player2 Damage: {player2.Damage}, Player3 Damage: {player3.Damage}");




        
        Plant plant = new Plant();

        
        
        plant.PrintStatus();
        
        plant.Grow();
        
        plant.PrintStatus();
        
        plant.Grow();
        
        plant = new Plant();
        
        plant.PrintStatus();
        
        
        ScoreCounter one = new ScoreCounter();
        
        ScoreCounter two = one;
        ScoreCounter three = two;
        ScoreCounter four = three;
        
        one.IncreaseScore();
        two.IncreaseScore();
        three.IncreaseScore();
        four.IncreaseScore();
        
        Console.WriteLine($"Score of one: {one.Score}");
        Console.WriteLine($"Score of two: {two.Score}");
        Console.WriteLine($"Score of three: {three.Score}");
        Console.WriteLine($"Score of four: {four.Score}");
        
        {
            House myHouse = new House("John");
            
            myHouse.PrintOwner();
            
            Sell(myHouse);
            
            myHouse.PrintOwner();
        }

        
        static void Sell(House house)
        {
            house.Owner = "Alex"; 
        }
    }
}