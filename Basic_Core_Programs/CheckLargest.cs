using System;
using System.Collections.Generic;
using System.Text;

namespace Basic_Core_Programs
{
    class CheckLargest
    {
        public void Largest(int number1, int number2, int number3)
        {
            if(number1 == number2 && number2 ==  number3)
                 Console.WriteLine("All inputs are equal");
            if(number1 > number2 && number1 > number3)            
                Console.WriteLine($"{number1} is greater");            
             if(number2 > number1 && number2 > number3)
                Console.WriteLine($"{number2} is greater");
             if(number3 > number1 && number3 > number2)
                Console.WriteLine($"{number3} is greater"); 
        }
    }
}
