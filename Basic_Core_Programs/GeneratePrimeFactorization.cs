﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Basic_Core_Programs
{
    class GeneratePrimeFactorization
    {
        public void PrimeFactor(int number)
        {
            //number should be greater than 1.
            while(number % 2 ==0)
            {
                Console.Write(2 +" ");
                number /= 2;
            }
            
            for (int i=3; i<= number; i++)
            {
                while(number % i == 0)
                {
                    Console.Write(i +" ");
                    
                    number /= i;
                }
            }

            if(number > 2)
            {
                Console.Write(number);
            }

        }
    }
}
