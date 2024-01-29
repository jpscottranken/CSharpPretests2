using System;
using static System.Console;

/*
 *      Days on Earth:
 *      Write a C# Sharp Console program 
 *      to input a person's age. Then 
 *      calculate the number of days they 
 *      have been on the Earth as of today.
 */

namespace Pretest01_04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //  Input person's age
            Write("Please enter your age:\t");
            decimal age = Decimal.Parse(Console.ReadLine());

            decimal daysOnEarth = age * 365.25m;
            daysOnEarth = Math.Round(daysOnEarth);

            Write("As of today, you have been on Earth ");
            WriteLine("for approximately " + daysOnEarth.ToString() +
                      " days");

            ReadLine();
        }
    }
}
