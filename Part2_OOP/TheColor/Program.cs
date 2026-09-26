
Color colorOne = new Color(125, 92, 37);
string colorName = "blue";
Color colorTwo = new Color(colorName);

Console.WriteLine($"First color: {colorOne.red} {colorOne.green} {colorOne.blue}");
Console.WriteLine($"Second color ({colorName}): {colorTwo.red} {colorTwo.green} {colorTwo.blue}");

Console.WriteLine("Provide a color code:");
Console.WriteLine("Red: ");
int red = int.TryParse(Console.ReadLine(), out int value) ? value : 0;
Console.WriteLine("Green: ");
int green = int.TryParse(Console.ReadLine(), out value) ? value : 0;
Console.WriteLine("Blue: ");
int blue = int.TryParse(Console.ReadLine(), out value) ? value : 0;
Color colorThree = new Color(red, green, blue);
Console.WriteLine($"Custom color: {colorThree.red} {colorThree.green} {colorThree.blue}");
Console.WriteLine("Provide a color name:");
string colorFromConsole = Console.ReadLine();
Color colorFour = colorFromConsole!="" ? new Color(colorFromConsole) : new Color();
Console.WriteLine($"Color from console ({colorFromConsole}): {colorFour.red} {colorFour.green} {colorFour.blue}");
public class Color
{

    public int red { get; set; }
    public int green { get; set; }
    public int blue { get; set; }

    public static Color White = new Color(255, 255, 255);
    public static Color Black = new Color(0, 0, 0);
    public static Color Red = new Color(255, 0, 0);
    public static Color Orange = new Color(255, 165, 0);
    public static Color Yellow = new Color(255, 255, 0);
    public static Color Green = new Color(0, 128, 0);
    public static Color Blue = new Color(0, 0, 255);
    public static Color Purple = new Color(128, 0, 128);

    public Color()
    {
        this.red = 0;
        this.green = 0;
        this.blue = 0;
    }
    public Color(int red, int green, int blue)
    {
        this.red = red;
        this.green = green;
        this.blue = blue;
    }

    public Color(string color)
    {
        switch (color)
        {
            case "white":
                this.red = White.red;
                this.green = White.green;
                this.blue = White.blue;
                break;
            case "black":
                this.red = Black.red;
                this.green = Black.green;
                this.blue = Black.blue;
                break;
            case "red":
                this.red = Red.red;
                this.green = Red.green;
                this.blue = Red.blue;
                break;
            case "orange":
                this.red = Orange.red;
                this.green = Orange.green;
                this.blue = Orange.blue;
                break;
            case "yellow":
                this.red = Yellow.red;
                this.green = Yellow.green;
                this.blue = Yellow.blue;
                break;
            case "green":
                this.red = Green.red;
                this.green = Green.green;
                this.blue = Green.blue;
                break;
            case "blue":
                this.red = Blue.red;
                this.green = Blue.green;
                this.blue = Blue.blue;
                break;
            case "purple":
                this.red = Purple.red;
                this.green = Purple.green;
                this.blue = Purple.blue;
                break;
            default:
                Console.Error.WriteLine("Incorrect color");
                break;
        }
    }

}