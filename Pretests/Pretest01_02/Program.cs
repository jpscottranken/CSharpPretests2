using System;
using static System.Console;

/*
 *      Convert Seconds:
 *      Write a C# Sharp Console program that 
 *      takes an integer representing a number 
 *      of seconds and converts it into the 
 *      number of hours and minutes. Round up 
 *      the seconds if they are >= 30 and 
 *      round down for < 30.
 */

namespace Pretest01_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string secStr;
            int seconds;
            int minutes;
            int hours;
            int whatsLeft;

            //  Input number of seconds
            Write("Input Number Of Seconds:\t");
            secStr = ReadLine();

            //  Convert seconds from string to integer
            seconds = Int32.Parse(secStr);

            //  Calculate hours
            hours = seconds / 3600;

            //  Figure out whatsLeft
            whatsLeft = seconds % 3600;

            //  Calculate minutes
            minutes = (whatsLeft + 30) / 60;

            //  Output results
            WriteLine(seconds.ToString() + " seconds = " +
                      hours.ToString()   + " hours and " +
                      minutes.ToString() + " minutes");

            ReadLine();
        }
    }
}
