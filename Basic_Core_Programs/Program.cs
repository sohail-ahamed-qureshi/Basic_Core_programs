using System;

namespace Basic_Core_Programs
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Basic Core Programs");
            // flip coin 
            FlipCoin flipCoin = new FlipCoin();
            flipCoin.PercentageFlips(10);

            //leap year
            CheckLeapYear leap = new CheckLeapYear();
            leap.LeapYear(2002);
        }
    }
}
