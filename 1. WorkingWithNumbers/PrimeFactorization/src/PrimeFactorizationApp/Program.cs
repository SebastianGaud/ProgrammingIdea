using System;
using System.Collections.Generic;
using PrimeFactorizationLib;

namespace PrimeFactorizationApp
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Insert number: ");
            var choice = Convert.ToInt32(Console.ReadLine());
            var primeFactors = new Dictionary<int, int>();

            foreach (var item in PrimeFactorization.GetPrimeFactors(choice))
            {
                System.Console.WriteLine(String.Format("There is {0} of {1}.", item.Value, item.Key));
            }
        }


        
    }
}
