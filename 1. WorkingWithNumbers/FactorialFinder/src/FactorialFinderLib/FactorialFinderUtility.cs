using System.Collections.Generic;

namespace FactorialFinderLib
{
    public class FactorialFinderUtility
    {
        public static List<int> GetFactorialWithForCycle(int n){
            var factorial = new List<int>();

            if (n <= 1)
            {
                factorial.Add(1);
                return factorial;
            }
            
            for (int i = (n -1); i > 1 ; i--)
            {
                factorial.Add(n * i);
            }

            return factorial;
        }


        public static int GetFactorialWithRecursion(int n) {
            if(n <= 1) return 1;
            else {
                System.Console.WriteLine(n * (n-1));
                return n * GetFactorialWithRecursion(n-1);
            }
        }
    }
}