// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Rectangle rectangle = new Rectangle(2,3);
rectangle.Width = 10;
Console.WriteLine($"Width: {rectangle.Width}, Height: {rectangle.Height}, Area: {rectangle.Area}");

Circle c1 = new Circle() { X = 1, Y = 3, Radius = 1 };
Console.WriteLine($"Circle 1 (X,Y)={c1.X},{c1.Y}, radius = {c1.Radius}");

// In case when contructor of class isparameterless - parentheses can be skipped
Circle c2 = new Circle { X = 2, Y = 4, Radius = 2};
Console.WriteLine($"Circle 2 (X,Y)={c2.X},{c2.Y}, radius = {c2.Radius}");

Player player = new Player();
player.Name = "Test";
player.Score = 10;
Console.WriteLine($"Player: {player.Name}, Score: {player.Score}");

public class Rectangle
{
    private float _width;
    private float _height;

    public Rectangle(float width, float height)
    {
        _width = width;
        _height = height;
    }
    // Property with getter and setter
    public float Width
    {
        get => _width;
        set => _width = value;
    }

    /* 
     Another way of defining 
     public float Width {
    get {return _width; }
    set {_width = value; }
     }
     */

    public float Height
    {
        get => _height;
        set => _height = value;
    }

    public float Area => _width * _height;

    // Property can also be private
    //private float Area => _width * _height;
}

public class Circle
{
    public float X { get; init; } = 0;
    public float Y { get; init; } = 0;
    public float Radius { get; init; } = 0;
}


public class Player
{
    // Readonly - that field cannot be changed after construction
    // private readonly string _name = "";

    private string _name = "";
    private int _score;
    public string Name
    {
        get => _name;
        set => _name = value;
    }

    public int Score { get; set; } = 0;

}