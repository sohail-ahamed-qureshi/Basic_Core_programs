using System;
using System.Collections.Generic;
using System.Text;

namespace Basic_Core_Programs
{
    class CheckLeapYear
    {
        public void LeapYear(int year)
        {
            if (year <= 999)
            {
                Console.WriteLine("Invalid year");

            }
            else if (year % 4 ==0 || year % 100 != 0 && year % 4 ==0)
            {
                Console.WriteLine($"{year} is a Leap year");
            }
            else
            {
                Console.WriteLine($"{year} is not a leap year");
            } 
        }
    }
}
