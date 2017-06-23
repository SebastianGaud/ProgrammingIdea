using System.Collections.Generic;

namespace FactorialFinderLib
{
    public class FactorialFinderUtility
    {
        public static int GetFactorialWithForCycle(int n){
            var factorial = new List<int>();
            int fact = 1;
            if (n <= 1)
            {
                return 1;
            }

            for (int i = n; i >= 2; i--){ 
                fact = fact * i;
            }
            return fact;
        }


        public static int GetFactorialWithRecursion(int n) {
            if(n <= 1) return 1;
            else {
                //System.Console.WriteLine(n * (n-1));
                return n * GetFactorialWithRecursion(n-1);
            }
        }
    }
}