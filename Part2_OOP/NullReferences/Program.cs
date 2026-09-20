// See https://aka.ms/new-console-template for more information
using static System.Formats.Asn1.AsnWriter;

Console.WriteLine("Hello, World!");

string name = null; // null indicates absence of the value
Console.WriteLine($"Provided name: {name}");
//Console.WriteLine($"Length of the name: {name.Length}"); // Running this line will resort in an error
// We can indicate with question mark (?) that variable can hold null value

string? firstName = Console.ReadLine();
Console.WriteLine($"Provided first name: {firstName}");

Players players = new Players();
Console.WriteLine($"Top player name: {players.GetTopPlayerName()}");

//public class Players
//{
    
//    //

//    private string? GetTopPlayerName()
//    {
//        return _scoreManager.GetScores()[0].Name; // Any of these could return null value
//    }
//}

// Hard to read version of the code:

public class Score()
{
    public string? name { get; set; } = null;
    public int? points { get; set; } = null;
}
public class ScoreManager()
{
    internal Score[]? scores;
    public Score[]? GetScores()
    {
        return scores;
    }
}

public class Players()
{
    private ScoreManager _scoreManager = new ScoreManager();

    //private string? GetTopPlayerName()
    //{
    //    if (_scoreManager == null) return null;

    //    Score[]? scores = _scoreManager.GetScores();
    //    if (scores == null) return null;

    //    Score? topScore = scores[0];
    //    if (topScore == null) return null;

    //    return topScore.name;
    //}
    
    //private string? GetTopPlayerName()
    //{
    //    return _scoreManager?.GetScores()?[0]?.name; //Now if any of these return null evaluation will be stopped - null will be returned
    //}

    public string? GetTopPlayerName()
    {
        return _scoreManager?.GetScores()?[0]?.name ?? "not found";  // Null coalescing operator (??) - what gets returned if null value was encountered
    }
}