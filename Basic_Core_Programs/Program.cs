using System;

namespace Basic_Core_Programs
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Basic Core Programs");
            Console.WriteLine("Enter your choice: ");
            Console.WriteLine("Press 1. for Flip coin. ");
            Console.WriteLine("Press 2. for Leap year. ");
            Console.WriteLine("Press 3. for Power of 2. ");
            Console.WriteLine("Press 4. for Harmonic Number. ");
            Console.WriteLine("Press 5. for Flip coin. ");
            Console.WriteLine("Press 6. for Flip coin. ");
            Console.WriteLine("Press 7. for Flip coin. ");
            Console.WriteLine("Press 8. for Flip coin. ");
            Console.WriteLine("Press 9. for Flip coin. ");
            Console.WriteLine("Press 10. for Flip coin. ");

            int selection = Convert.ToInt32( Console.ReadLine());

            switch (selection)
            {
                case 1:
                    // flip coin 
                    FlipCoin flipCoin = new FlipCoin();
                    flipCoin.PercentageFlips(10);
                    break;
                case 2:
                    //leap year
                    CheckLeapYear leap = new CheckLeapYear();
                    leap.LeapYear(2002);
                    break;
                case 3:
                    //power of 2
                    PowerOf2 pow = new PowerOf2();
                    pow.CheckPower(32);
                    break;
                case 4:
                    //Harmonic Number
                    GenerateHarmonicNumber har = new GenerateHarmonicNumber();
                    har.HarmonicNumber(8);
                    break;
                default:
                    Console.WriteLine("invalid selection made.");
                    break;



            }






        }
    }
}
