
Point firstPoint = new Point(2, 3);
Point secondPoint = new Point(-4, 0);

Console.WriteLine($"First point: ({firstPoint.x}, {firstPoint.y})");
Console.WriteLine($"Second point: ({secondPoint.x}, {secondPoint.y})");

public class Point
{
    public int x { get; set; }
    public int y { get; set; }
    public Point()
    {
        this.x = 0;
        this.y = 0;
    }
    public Point(int x, int y)
    {
        this.x = x;
        this.y = y;
    }

}