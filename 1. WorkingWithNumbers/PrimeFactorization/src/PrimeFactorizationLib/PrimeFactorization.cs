using System.Collections.Generic;


namespace PrimeFactorizationLib
{
    public class PrimeFactorization
    {


        public static Dictionary<int, int> GetPrimeFactors(int choice)
        {
            var primeFactors = new Dictionary<int, int>();

            while (choice > 1)
            {
                int primefactor = FindFirstValidPrimeFactors(choice);
                choice = choice / primefactor;
                if (primeFactors.ContainsKey(primefactor))
                {
                    primeFactors[primefactor]++;
                }
                else
                {
                    primeFactors.Add(primefactor, 1);
                }
            }


            return primeFactors;
        }
        //Essenziali find first primefactor i can use.
        private static int FindFirstValidPrimeFactors(int number)
        {
            foreach (var item in PrimeNumberCalculations.GetOneByOnePrime())
            {
                if (number % item == 0)
                {
                    return item;
                }
            }
            return 0;
        }
    }
}