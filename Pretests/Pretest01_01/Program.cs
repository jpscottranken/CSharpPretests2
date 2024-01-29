using System;
using static System.Console;

/*
 *      Vote Checker:
 *      Write a C# Sharp Console program 
 *      that takes an age (for example 20) 
 *      as input and prints something 	
 *      like 20 is old enough to vote 
 *      or (for example) 13 is not old 
 *      enough to vote. Assume 18 is the 
 *      legal voting age. Use a constant.
 */

namespace Pretest01_01
{
    internal class Program
    {
        //  Declare and initialize program constant.
        const int MINVOTINGAGE = 18;

        static void Main(string[] args)
        {
            Write("Please enter your age:\t");
            //int age = Int32.Parse(ReadLine());
            string ageStr = ReadLine();

            //  Convert ageStr to an integer
            int age = Int32.Parse(ageStr);

            if (age >= MINVOTINGAGE)
            {
                //WriteLine(age.ToString() + " IS old enough to vote.");
                WriteLine($"{age} IS old enough to vote.");
            }
            else
            {
                //WriteLine(age.ToString() + " IS NOT old enough to vote.");
                WriteLine($"{age} IS NOT old enough to vote.");
            }

            ReadLine();
        }
    }
}
