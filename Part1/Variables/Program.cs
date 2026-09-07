string username;
int score;
int x = 0;
int a, b, c;
a = b = c = 10;

/* Variaables rules naming */
/* 1. Starts with the letter or underscore ("_")
 * 2. No whitespaces allowed and other symbols */

/* Naming guidelines 
 * 1. Accurate descriptive names
 * 2. No abbrevations
 * 3. Longer names are okay
 * 4. Avoid numbers in names
 * 5. Multi word clear names: camelCase, PascalCase */

/* Integers */
byte aByte = 34;
short aNumber = 3000;
long aBigNumber = 3000000000;

/* Digit Seperator */
aBigNumber = 3_000_000_000; // Underscores are allowed in numbers for readability
Console.WriteLine($"Byte: {aByte}, Short: {aNumber}, Long: {aBigNumber}");

/* Boolean */
bool isTrue = true;
bool isFalse = false;

/* Type Inference */
var message = "Hello!";
// message = 3; is not allowed 
// var message; would not compile

/* Conversion */
int number = Convert.ToInt32("134");
int anotherNumber = int.Parse("134");

/* Casting operator */
byte aSecondByte = (byte)number;
double aFraction = (double)number / anotherNumber;

/* MATH */
double radius = 10.0;
double area = Math.PI * radius * radius;
area = Math.PI * Math.Pow(radius, 2);
double squareRoot = Math.Sqrt(144);
double sine = Math.Sin(Math.PI / 2);
double cosine = Math.Cos(Math.PI / 4);
float y = 5;
float ySquared = MathF.Pow(y, 2); // Float