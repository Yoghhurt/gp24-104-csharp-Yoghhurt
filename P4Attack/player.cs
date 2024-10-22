class Player
{
    public int Damage { get; set; } = 0;

    public void Attack(Player target)
    {
        target.Damage++;
    }
}