int score = 100;

if (score == 100)
    Console.WriteLine("Score 100");
if (score == 100) Console.WriteLine("Score 100");
if (score == 100)
{
    Console.WriteLine("Score 100");
    Console.WriteLine("Congratulations !");
}

score = 200;
if (score == 100)
{
    Console.WriteLine("Score 100");
    Console.WriteLine("Congratulations !");
}
else
{
    Console.WriteLine("Score 200");
    Console.WriteLine("Incorrect Score");
}

score = 50;
if (score == 100)
{
    Console.WriteLine("Score 100");
    Console.WriteLine("Congratulations !");
}
else if (score == 50)
{
    Console.WriteLine("Score 50");
    Console.WriteLine("Not so well");
}
else
{
    Console.WriteLine("Score 200");
    Console.WriteLine("Incorrect Score");
}

bool isPassed = score >= 50;
if (isPassed)
    {
    Console.WriteLine("You passed the exam");
}
else
{
    Console.WriteLine("You failed the exam");
}

// Conditional Operator
string text = score >= 50 ? "You passed the exam" : "You failed the exam";
Console.WriteLine(text);

int choice = Convert.ToInt32(Console.ReadLine());

switch (choice)
{
    case 1:
        Console.WriteLine("You selected option 1");
        break;
    case 2:
        Console.WriteLine("You selected option 2");
        break;
    case 3:
        Console.WriteLine("You selected option 3");
        break;
    default:
        Console.WriteLine("Invalid option");
        break;
}

string response = choice switch
{
    1 => "You selected option 1",
    2 => "You selected option 2",
    3 => "You selected option 3",
    _ => "Invalid option"
};
Console.WriteLine(response);