using System;
using System.Collections.Generic;
using System.Text;

namespace Basic_Core_Programs
{
    class OddEven
    {
        public void CheckOddEven(int number)
        {
            if (number % 2 == 0)
            {
                Console.WriteLine($"{number} is even");
            }
            else
            {
                Console.WriteLine($"{number} is odd");

            }
        }
    }
}
