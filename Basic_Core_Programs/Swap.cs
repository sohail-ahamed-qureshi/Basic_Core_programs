using System;
using System.Collections.Generic;
using System.Text;

namespace Basic_Core_Programs
{
    class Swap
    {
        public void SwapNumber(int a, int b)
        {
            //variables
            int temp;

            Console.WriteLine($"Before Swap a = {a}, b = {b}");
            temp = b;
            b = a;
            a = temp;

            Console.WriteLine($"After Swap a = {a}, b ={b}");
        }
    }
}
