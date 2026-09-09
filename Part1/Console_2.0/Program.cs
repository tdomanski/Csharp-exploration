Console.Title = "Console 2.0";

// See https://aka.ms/new-console-template for more information
Console.Write("Hello ");
string username = Console.ReadLine();

Console.BackgroundColor = ConsoleColor.DarkGray;
Console.ForegroundColor = ConsoleColor.Black;
Console.Clear();

// ReadKey method
//Console.WriteLine("Press any key (sound will be played)");
//Console.ReadKey(true); // Without true the key would be displayed
//Console.WriteLine("...");
//Console.Beep(440, 1500);

// Escape sequence
Console.WriteLine("\"Title\"");
Console.WriteLine("Path: \"C:\\Users\\User\\Desktop\\File.txt\"");

// StringLiteral
string path = @"C:\Users\User\Desktop\File.txt";
Console.WriteLine("Path "+path);
Console.WriteLine($"Path {path}");

// Alignment
string firstName = "John";
string secondName = "Captain America";
Console.WriteLine($"#1: {firstName, 20}");
Console.WriteLine($"#2: {secondName, 20}");

// Intro to formatting
double pi = Math.PI;
Console.WriteLine(pi);
Console.WriteLine($"Display 3 digits after dec point: {pi:0.000}");
Console.WriteLine($"Display digits before dec point even when there are no digits: {pi:00.000}");
//Display only when digit exists
int anotherNumber = 52; 
Console.WriteLine($"Display digits before dec point only when there are digits (pi:#.##): {pi:#.##}");
Console.WriteLine($"Display digits before dec point only when there are digits (52:#.##): {anotherNumber:#.##}");

// DisplayPercentages
float currentValue = 10;
float maxValue = 15;
Console.WriteLine($"Perc: {currentValue / maxValue:0.0%}");