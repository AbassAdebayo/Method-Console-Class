// See https://aka.ms/new-console-template for more information

using Method_Class;
//
// string MorningGreetings(string day)
// {
//     return $"Good {day}!";
// }
//
// void Sum(int a, int b)
// { 
//     Console.WriteLine(a + b);
// }
//
// int Add(int a, int b)
// {
//     return a + b;
// }
//
// string day = "Morning";
//
// int a = 5, b = 6;
// Sum(a, b);
// Console.WriteLine(Add(a, b));
// Console.WriteLine(MorningGreetings(day));
//
// void FullNames(string firstName, string lastName, string middleName)
// {
//     Console.WriteLine(firstName + " " + lastName + " " + middleName);
// }
//
// string firstName = "Abass";
// string lastName = "Adebayo";
// string middleName = "Ayodeji";
//
// FullNames(firstName, lastName, middleName);
//
// int SumNumbers(params int[] numbers)
// {
//     return numbers.Sum();
// }
//
// Console.WriteLine(SumNumbers(2, 2, 3, 10, 15));

// Shape calc = new Shape();
//
// double length = 4.5;
// double width = 10;
//
// Console.WriteLine(calc.CalculateAreaOfRectangle(length, width));
//
// Person person = new Person();
//
//
// Console.Write("Enter firstName: ");
// string firstName = Console.ReadLine();
//
// Console.Write("Enter lastName: ");
// string lastName = Console.ReadLine();
//
// Console.Write("Enter age: ");
// int age = Convert.ToInt32(Console.ReadLine());
//
// Console.Write("Enter gender: ");
// string gender = Console.ReadLine();
//
// Console.WriteLine(person.PersonalData(firstName, lastName, age, gender));

// Console.Write("Enter words you want to check their indexes: ");
// string input = Console.ReadLine();
//
// string lettersToLower = input.ToLower();
//
// ArrayMethods indexOfLetters = new ArrayMethods();
//
// indexOfLetters.IndexOfLetters(lettersToLower);

// ArrayMethods printMatrix = new ArrayMethods();
//
// Console.Write("Enter the numbers of rows: ");
// int rows = Convert.ToInt32(Console.ReadLine());
//
// Console.Write("Enter the numbers of columns: ");
// int cols = Convert.ToInt32(Console.ReadLine());
//
// int [,] matrix = new int[rows, cols];
//
// printMatrix.PrintMatrix(matrix, rows, cols);

Palindrome palindrome = new Palindrome();



Console.Write($"isPalindrome => {palindrome.IsPalindrome($"A man, a plan, a canal, Panama!")}");