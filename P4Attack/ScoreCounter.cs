class ScoreCounter
{
    public int Score { get; private set; }

    public ScoreCounter()
    {
        Score = 0; // Initialize score
    }

    public void IncreaseScore()
    {
        Score++;
    }
}