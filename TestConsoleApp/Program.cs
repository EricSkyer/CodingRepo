using Lib.Al;
using Lib.Ds;

// See https://aka.ms/new-console-template for more information


int[] numbers = [1, 2, 3, 4, 5, 6, 7, 8, 9, 10];


Console.WriteLine("Hello, World!");
int result = Search.LinearSearch(numbers, 12);
Console.WriteLine(result);
result = Search.LinearSearch(numbers, 6);
Console.WriteLine(result);

result = Search.BinarySearch(numbers, 12);
Console.WriteLine(result);
result = Search.BinarySearch(numbers, 6);
Console.WriteLine(result);

bool recResult = Search.RecursiveBinarySearch(numbers, 12, 0, numbers.Length - 1);
Console.WriteLine(recResult);
recResult = Search.RecursiveBinarySearch(numbers, 6, 0, numbers.Length - 1);
Console.WriteLine(recResult);