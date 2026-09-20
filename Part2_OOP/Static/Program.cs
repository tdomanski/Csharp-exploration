// See https://aka.ms/new-console-template for more information
using System.Reflection.Metadata.Ecma335;

Console.WriteLine("Hello, World!");

// Static field/variable affect every instance of the class

Rectangle rectangle = Rectangle.CreateSquare(2); // <- Similar to Console.WriteLine/Convert.ToInt32 - these are also static methods

public class Score
{
    private int points;
    private int level;
    public static int PointThreshold { get; } = 1000; //Stattic properties can only return static variable
    private static int LevelThreshold { get; } = 4;
    //private static readonly int PointThreshold = 1000; // Static variables are usally written with UpperCamelCase
    //private static readonly int LevelThreshold = 4;

    // Consturctor can also be static - it is initiated for the first time when class is created - it cannot have paramaters or be called directly (public/private modifier cannot be used)
    static Score()
    {
        PointThreshold = 1000;
        LevelThreshold = 4;
    }
    
    public bool ISWorthyOfTheHighScoreTable()
    {
        if (points < PointThreshold) return false;
        if (level < LevelThreshold) return false;
        return true;
    }

    //public static StaticMethod() { };  <- Methods can also be static - not related to an instance of the class
}

public class Rectangle
{
    private float _width;
    private float _height;

    public Rectangle(float width, float height)
    {
        _width = width;
        _height = height;
    }
    //############################################################//
    // Factory method (instead of calling constructor)
    public static Rectangle CreateSquare(float size) => new Rectangle(size, size);

    //############################################################//
    public float Width
    {
        get => _width;
        set => _width = value;
    }

    public float Height
    {
        get => _height;
        set => _height = value;
    }

    public float Area => _width * _height;
}


// Static classes can be used for utility methods - it is not possible to create instances of that class

public static class Utilities
{
    public static int MultiplyNumbers(int a, int b) => a * b;
    public static float AddNumbers(float a, float b) => a + b;
}