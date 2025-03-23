namespace MathGame.Models;

internal class Game
{
    public DateTime Date { get; set; }
    public int Score { get; set; }
    public DifficultyLevel Difficulty { get; set; }
    public GameType Type { get; set; }
}

internal enum GameType
{
    Addition,
    Subtraction,
    Multiplication,
    Division,
    Random
}

internal enum DifficultyLevel
{
    Easy,
    Medium,
    Hard,
    Expert
}
