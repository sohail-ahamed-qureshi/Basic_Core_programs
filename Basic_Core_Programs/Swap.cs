using System;
using System.Collections.Generic;
using System.Text;

namespace Basic_Core_Programs
{
    class Swap
    {
        public void SwapNumber(int a, int b)
        {
            Console.WriteLine($"Before Swap a = {a}, b = {b}");
            a = a + b;
            b = a - b;
            a = a -b;
            Console.WriteLine($"After Swap a = {a}, b ={b}");
        }
    }
}
