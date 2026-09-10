// Array can hold ten elements
int[] scores = new int[10];

scores[0] = 99;
scores[scores.Length - 1] = 100; // Assigning value to the last element of the array

Console.WriteLine(scores[0]); // Output: 99
Console.WriteLine(scores[1]); // Uninitialized aarray element is zero by default

// Check length of the array
Console.WriteLine(scores.Length); // Output: 10

for(int i = 0; i < scores.Length; i++)
{
    Console.WriteLine($"Element at index {i}: {scores[i]}");
}

Console.WriteLine(scores[^1]); // Output: 0, last element of the array)

int[] anotherScores = new int[5] { 10, 20, 30, 40, 50 };
//int[] anotherScores = new int[] { 10, 20, 30, 40, 50 }; // - also allowed

// Foreach loop to iterate through the array    
foreach (int score in anotherScores)
{
    Console.WriteLine(score);
}

// 2D Matrix
int[][] matrix = new int[3][];
matrix[0] = new int[] { 1, 2};
matrix[1] = new int[] { 3, 4};
matrix[2] = new int[] { 5, 6};
Console.WriteLine(matrix[0][0]);
for (int i = 0; i < matrix.Length; i++)
{
    for (int j = 0; j < matrix[i].Length; j++)
    {
        Console.WriteLine($"Element at [{i}][{j}]: {matrix[i][j]}");
    }
}