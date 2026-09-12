CountToTen();

void CountToTen()
{
    for (int current = 1; current <= 10; current++)
    {
        System.Console.WriteLine(current);
    }
}

CountToTen();

int current = -10;

System.Console.WriteLine($"current (before loop): {current}");
CountToFive();
System.Console.WriteLine($"current (after loop): {current}");
static void CountToFive()
{
        //Console.WriteLine(current); // This will not work thanks to static - current is not in scope here
        for (int current = 1; current <= 5; current++)
    {
        System.Console.WriteLine($"current (in loop): {current}");
    }
}

CountToNumber(5);

void CountToNumber(int number)
{
    for (int current = 1; current <= number; current++)
    {
        System.Console.WriteLine(current);
    }
}

int ReadNumber()
{
    string input = Console.ReadLine();
    int number = Convert.ToInt32(input);
    return number;
}

Console.WriteLine("Provide a number: ");
int number = ReadNumber();
Console.WriteLine($"You entered: {number}");

Count(-10);
Count(3);

/// <summary>
/// Counts from 1 to the specified number.
/// </summary>
/// <param name="number">The number to count to.</param>
void Count(int number)
{
    if (number < 1)
    {
        System.Console.WriteLine("Number must be greater than 0");
        return;
    }
    
    for (int current = 1; current <= number; current++)
    {
        System.Console.WriteLine(current);
    }
}


// Expression body (for one liners)
int DoubleAndAddOne(int value) => value * 2 + 1;

//Recursion
int Factorial(int number)
{
    if (number == 1) return 1;
    return number * Factorial(number - 1);
}

int factorialResult = Factorial(3);
Console.WriteLine($"Factorial of 3 is: {factorialResult}");