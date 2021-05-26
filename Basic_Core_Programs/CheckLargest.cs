using System;
using System.Collections.Generic;
using System.Text;

namespace Basic_Core_Programs
{
    class CheckLargest
    {
        public void Largest(int number1, int number2, int number3)
        {
            if(number1 > number2 && number1 > number3)
            {
                Console.WriteLine($"{number1} is greater");
            }
            else if(number2 > number1 && number2 > number3)
            {
                Console.WriteLine($"{number2} is greater");

            }
            else
            {
                Console.WriteLine($"{number3} is greater");
            }
        }
    }
}
