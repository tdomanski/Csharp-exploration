// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Score bestScore = new Score();
bestScore.name = "Player1";
bestScore.points = 5000;
bestScore.level = 3;

if (bestScore.EarnedStar())
{
    Console.WriteLine($"{bestScore.name} earned a star!");
}
else
{
    Console.WriteLine($"{bestScore.name} did not earn a star.");
}

Rectangle rect = new Rectangle(5, 10);
Console.WriteLine($"Rectangle area: {rect.getArea()}");
rect.setWidth(7);
Console.WriteLine($"Rectangle area: {rect.getArea()}");
class Score
{
    public string name;
    public int points;
    public int level;

    // Constructor
    public Score()
    {
        name = "Unknown";
        points = 0;
        level = 1;
    }

    //public Score() : this("Unknown", 0, 1) { } // This is a constructor initializer that calls the other constructor

    // 'this' - refers to the object you are currently in
    public Score(string name, int points, int level)
    {
        this.name = name;
        this.points = points;
        this.level = level;
    }

    public bool EarnedStar() => (points / level) > 1000;


}