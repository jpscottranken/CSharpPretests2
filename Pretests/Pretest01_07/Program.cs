using System;
using static System.Console;

/*
 *      EX1	Write a GUI-based program 
 *      that converts distances between 
 *      feet and yards.
 *      
 *      ●	The program must contain a 
 *          constant named FT_PER_YD 
 *          which holds the number of 
 *          feet per yard (3 feet = 1 yard). 
 *          Create the constant like this:  
 *          const int FT_PER_YD = 3;
 *      ●	Prompt the user for a distance 
 *          in feet.
 *      ●	Once the user presses a button, 
 *          display the distance in both feet 
 *          and yards as follows: 
 *          6 feet = 2 yards
 */

namespace Pretest01_07
{
    internal class Program
    {
        //  Declare and initialize program constant
        const int FT_PER_YD = 3;

        static void Main(string[] args)
        {
            Write("Please enter feet:\t");
            decimal feet = Convert.ToDecimal(ReadLine());
            decimal yards;

            ////  If feet left empty, return
            //if (feet.ToString() == "")
            //{
            //    return;
            //}

            yards = feet / FT_PER_YD;

            //WriteLine(feet.ToString("n2") + " feet = " +
            //                yards.ToString("n2") + " yards.");

            WriteLine($"{feet:n2} feet = {yards:n2} yards");

            ReadLine();
        }
    }
}
