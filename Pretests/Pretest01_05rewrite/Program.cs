using System;
using static System.Console;

/*
 *      Write a C# Sharp program that 
 *      takes four numbers as input and 
 *      calculates and prints the 
 *      smallest number, the largest 
 *      number, and the average.
 */

namespace Pretest01_05rewrite
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the first number: ");
            double num1 = double.Parse(Console.ReadLine());

            Console.Write("Enter the second number: ");
            double num2 = double.Parse(Console.ReadLine());

            Console.Write("Enter the third number: ");
            double num3 = double.Parse(Console.ReadLine());

            Console.Write("Enter the fourth number: ");
            double num4 = double.Parse(Console.ReadLine());

            // Calculate smallest, largest, and average
            double smallest = Math.Min(Math.Min(num1, num2), Math.Min(num3, num4));
            double largest = Math.Max(Math.Max(num1, num2), Math.Max(num3, num4));
            double average = (num1 + num2 + num3 + num4) / 4;

            // Display the result
            Console.WriteLine($"Smallest number: {smallest}");
            Console.WriteLine($"Largest number: {largest}");
            Console.WriteLine($"Average: {average}");
        }
    }
}
