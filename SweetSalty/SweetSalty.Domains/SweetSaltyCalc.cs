using System;

namespace SweetSalty.Domains
{
    public class SweetSaltyCalc
    {
        // Constructor
        public SweetSaltyCalc() { }

        // Set variablees for Start Number, Max Number
        public int StartNum { get; set; } = 1;
        public int MaxNum { get; set; } = 1000;

        // Set variables for Sweet and Salty variables
        public int SweetInt { get; set; } = 3;
        public int SaltyInt { get; set; } = 5;

        // Set variable for linebreak per 10 numbers
        public int LineBreak { get; set; } = 10;

        // Set variables for counting number of times each test passes
        public int SweetCount { get; set; } = 0;
        public int SaltyCount { get; set; } = 0;
        public int SweetSaltyCount { get; set; } = 0;

        // Set variables for String representation of sweet, salty, and sweetnsalty
        public string SweetStr { get; set; } = "sweet ";
        public string SaltyStr { get; set; } = "salty ";
        public string SweetSaltyStr { get; set; } = "sweet'nSalty ";

        /*Use for loop to test for calculation of 1000 numbers
        if result is divisible by 3, then print Sweet
        if result is divisible by 5, then print Salty
        if result is divisible by both 3 & 5, then print Sweet'nSalty*/
        public void Calculate()
        {
            for (int i = StartNum; i <= MaxNum; i++)
            {
                // set line break for 10 numbers per line
                if (i % LineBreak == 0)
                    System.Console.WriteLine();

                // use nested If/Else to perform calculations
                // Test for numbers divisible by 3 and 5, and increment SweetSaltyCounter
                if ((i % SweetInt == 0) & (i % SaltyInt == 0))
                {
                    System.Console.Write(SweetSaltyStr);
                    SweetSaltyCount += 1;
                }
                // Test for numbers divisible by 3, and increment SweetCounter
                else if (i % SweetInt == 0)
                {
                    System.Console.Write(SweetStr);
                    SweetCount += 1;
                }
                // Test for numbers divisible by 5, and increment SaltyCounter
                else if (i % SaltyInt == 0)
                {
                    System.Console.Write(SaltyStr);
                    SaltyCount += 1;
                }
                // If it isn't divisible by 3 and/or 5, then just print the number
                else
                    System.Console.Write($"{i} ");

                // at number 1000, print a line break after it prints
                if (i == MaxNum)
                    System.Console.WriteLine("\n");
            }
        }

        // This function prints the total count that Salty, Sweet, SweetSalty was printed
        public void PrintTotal()
        {
            System.Console.WriteLine("Totals:");
            System.Console.WriteLine($"Sweet count: {SweetCount}");
            System.Console.WriteLine($"Salty count: {SaltyCount}");
            System.Console.WriteLine($"Sweet'nSalty count: {SweetSaltyCount}");
        }
        
    }    

}