using System;
using static System.Console;

/*
 *      Sum & Average: 
 *      Write a C# Sharp program that 
 *      takes four numbers as input and 
 *      calculates and prints the smallest 
 *      number, the largest number, and 
 *      the average.
 */

namespace Pretest01_05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double smallest = 0.0;
            double largest  = 0.0;
            double sum      = 0.0;
            double average  = 0.0;

            //  Input four numbers
            Write("Enter Number 1:\t");
            double num1 = double.Parse(Console.ReadLine());

            Write("Enter Number 2:\t");
            double num2 = double.Parse(Console.ReadLine());

            Write("Enter Number 3:\t");
            double num3 = double.Parse(Console.ReadLine());

            Write("Enter Number 4:\t");
            double num4 = double.Parse(Console.ReadLine());

            //  Calculate largest number
            largest = Math.Max(Math.Max(num1, num2), Math.Max(num3, num4));


            //if (num1 >= num2)
            //{
            //    largest = num1;
            //}
            //else
            //{
            //    largest = num2;
            //}

            //if (num3 > largest)
            //{
            //    largest = num3;
            //}

            //if (num4 > largest)
            //{
            //    largest = num4;
            //}

            //  Calculate smallest number
            smallest = Math.Min(Math.Min(num1, num2), Math.Min(num3, num4));

            //if (num1 <= num2)
            //{
            //    smallest = num1;
            //}
            //else
            //{
            //    smallest = num2;
            //}

            //if (num3 < smallest)
            //{
            //    smallest = num3;
            //}

            //if (num4 < smallest)
            //{
            //    smallest = num4;
            //}

            //  Calculate the sum
            sum = num1 + num2 + num3 + num4;

            //  Calculate the average
            average = sum / 4;

            WriteLine("The largest  number is:\t" + largest.ToString());
            WriteLine("The smallest number is:\t" + smallest.ToString());
            WriteLine("The sum of 4 numbers is:\t" + sum.ToString());
            WriteLine("The avg of 4 numbers is:\t" + average.ToString("n2"));

            ReadLine();
        }
    }
}
