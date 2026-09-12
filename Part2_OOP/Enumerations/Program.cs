// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Season currentSeason = Season.Summer;
if (currentSeason == Season.Summer)
{
    Console.WriteLine("It's summer time!");
}
else
{
    Console.WriteLine("It's not summer.");
}
// Enumerations are always after other code
enum Season { Winter, Spring, Summer, Fall }
