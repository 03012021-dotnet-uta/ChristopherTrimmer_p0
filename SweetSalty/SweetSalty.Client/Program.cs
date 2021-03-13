using System;
using static System.Console;
using SweetSalty.Domains;

namespace SweetSalty.Client
{
    class Program
    {
        // Entry point of Program
        static void Main(string[] args)
        {
            // Create a SweetSalty object from Model
            SweetSaltyCalc mySweetSaltyObject = new SweetSaltyCalc();

            // Perform calculation and print the totals
            mySweetSaltyObject.Calculate();
            mySweetSaltyObject.PrintTotal();

            // Ensure shell does not exit before customer can interact
            Console.ReadLine();

        }
    }
}
