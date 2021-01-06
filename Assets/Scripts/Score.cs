public static class Score
{
    private static int playeronescore;
    private static int playertwoscore;

    public static int playerOneScore
    {
        get
        {
            return playeronescore;
        }
        set
        {
            playeronescore = value;
        }
    }

    public static int playerTwoScore
    {
        get
        {
            return playertwoscore;
        }
        set
        {
            playertwoscore = value;
        }
    }
}