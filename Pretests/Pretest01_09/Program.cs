using System;
using static System.Console;

/*
 *      Write a GUI-based program
 *      that asks the user for a 
 *      number and determines whether 
 *      the number is 0, odd, or even 
 *      (use the modulo operator). 
 */

namespace Pretest01_09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Write("Enter a number:\t");
            int number = Int32.Parse(ReadLine());

            if (number % 2 == 0)
            {
                WriteLine($"The number {number} is even.");
                //WriteLine("The number " + number.ToString()
                //          + " is an even number.");
            }
            else
            {
                WriteLine($"The number {number} is odd.");
                //WriteLine("The number " + number.ToString()
                //          + " is an odd number.");
            }

            ReadLine();
        }
    }
}
