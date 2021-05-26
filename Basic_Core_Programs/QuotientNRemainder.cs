using System;
using System.Collections.Generic;
using System.Text;

namespace Basic_Core_Programs
{
    class QuotientNRemainder
    {
        public void Divide(int dividend, int divisor)
        {
            int quotient,remainder;
            quotient = dividend % divisor;
            remainder = dividend / divisor;

            Console.WriteLine($"Quotient: {quotient}");
            Console.WriteLine($"Remainder: {remainder}");


        }
    }
}
