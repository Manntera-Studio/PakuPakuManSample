
public static class GameData
{
    public enum ResultKind
    {
        Clear,
        GameOver,
        None
    }

    public static int Score;
    public static ResultKind Result;

    public static void ResetResult()
    {
        Score = 0;
        Result = ResultKind.None;
    }
}