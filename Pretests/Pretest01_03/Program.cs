using System;
using static System.Console;

/*
 *      Convert H/M/S:
 *      Write a C# Sharp Console program 
 *      that takes 2 integers, representing 
 *      the number of hours and the number 
 *      of minutes and converts it into the 
 *      number of seconds.
 */

namespace Pretest01_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int hours;
            int minutes;
            int seconds;

            //  Input number of hours
            Write("Enter the number of hours:\t");
            hours = Convert.ToInt32(Console.ReadLine());

            //  Input number of minutes
            Write("Enter the number of minutes:\t");
            minutes = Convert.ToInt32(Console.ReadLine());

            //  Calculate total number of seconds
            seconds = (hours * 3600) + (minutes * 60);

            WriteLine($"{hours} hours and {minutes} minutes = {seconds} seconds.");
            //WriteLine(hours.ToString()   + " hours and " +
            //          minutes.ToString() + " minutes = " +
            //          seconds.ToString() + " seconds.");
            
            ReadLine();
        }
    }
}
