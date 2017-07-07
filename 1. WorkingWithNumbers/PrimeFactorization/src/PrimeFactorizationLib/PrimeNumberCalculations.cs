using System;
using System.Collections.Generic;
using System.Linq;

namespace PrimeFactorizationLib
{
    public class PrimeNumberCalculations
    {
        //Since i want to check infinte numbers i must return an infinte sequce of prime number
        //So i return one prime per time forever
        public static IEnumerable<int> GetOneByOnePrime()
        {
            for (int i = 2; i > -1; i ++)
            {
                if (IsPrime(i))
                {
                    yield return i;                
                }
            }
        }


        
        private static bool IsPrime(int number)
        {
            for (int i = 2; i < number; i++)
            {
                if (number % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
