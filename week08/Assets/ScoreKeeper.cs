public class ScoreKeeper
{
    
    public int PlayerScore { get; private set; }
    public int OpponentScore { get; private set; }

    
    public void AddScoreToPlayer(int points)
    {
        PlayerScore += points;
    }

    
    public void AddScoreToOpponent(int points)
    {
        OpponentScore += points;
    }

    
    public void SubtractScoreFromPlayer(int points)
    {
        PlayerScore = Math.Max(PlayerScore - points, 0);
    }

    
    public void SubtractScoreFromOpponent(int points)
    {
        OpponentScore = Math.Max(OpponentScore - points, 0);
    }

    
    public void ResetScores()
    {
        PlayerScore = 0;
        OpponentScore = 0;
    }
}
