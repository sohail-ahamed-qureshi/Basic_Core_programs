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
            Console.WriteLine("Press 5. for Prime factorization. ");
            Console.WriteLine("Press 6. to Compute Qoutient & Remainder. ");
            Console.WriteLine("Press 7. Swap two numbers. ");
            Console.WriteLine("Press 8. to check Number odd or even. ");
            Console.WriteLine("Press 9. Whether alphabet is vowel or Consonant. ");
            Console.WriteLine("Press 10. to check Largest amont three numbers. ");
            // user input 
            int selection = Convert.ToInt32( Console.ReadLine());
            // user selection
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
                case 5:
                    //Prime Factorization
                    GeneratePrimeFactorization prime = new GeneratePrimeFactorization();
                    prime.PrimeFactor(23);
                    break;
                case 6:
                    //Generate Quotient and Remainder
                    QuotientNRemainder div = new QuotientNRemainder();
                    div.Divide(315,3);
                    break;
                case 7:
                    //Swap two numbers
                    Swap num = new Swap();
                    num.SwapNumber(5, 10);
                    break;
                case 8:
                    //to check Number odd or even
                    OddEven oddEven = new OddEven();
                    oddEven.CheckOddEven(5);
                    break;
                case 9:
                    //Whether alphabet is vowel or Consonant
                    CheckAlphabet checkAlphabet = new CheckAlphabet();
                    checkAlphabet.CheckVowel('v');
                     break;
                case 10:
                    //to check Largest amont three numbers
                    CheckLargest checkLargest = new CheckLargest();
                    checkLargest.Largest(30, 30, 30);
                    break;
                default:
                    Console.WriteLine("invalid selection made.");
                    break;
            }
        }
    }
}
