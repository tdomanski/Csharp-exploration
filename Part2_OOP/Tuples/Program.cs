// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

(string, int, int) score = ("Alice", 10, 20);
var score2 = ("Bob", 15, 25);

Console.WriteLine($"Player: {score.Item1}, Score: {score.Item2}, Level: {score.Item3}");
Console.WriteLine($"Player: {score2.Item1}, Score: {score2.Item2}, Level: {score2.Item3}");

(string name, int point, int level) score3 = ("Charlie", 20, 30);

Console.WriteLine($"Player: {score3.name}, Score: {score3.point}, Level: {score3.level}");

(string name, int point, int level) GetScore()
{
    return ("David", 25, 35);
}

(string name, int point, int level) scoreDawid = GetScore();
Console.WriteLine($"Player: {scoreDawid.name}, Score: {scoreDawid.point}, Level: {scoreDawid.level}");

string name;
int points;
int level;
(name, points, level) = score;
Console.WriteLine($"Player: {name}, Score: {points}, Level: {level}");
(name, points, _) = score2;
Console.WriteLine($"Player: {name}, Score: {points}");
