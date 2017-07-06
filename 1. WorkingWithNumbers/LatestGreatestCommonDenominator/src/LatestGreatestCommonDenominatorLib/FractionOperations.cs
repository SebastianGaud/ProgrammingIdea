using System.Linq;

namespace LatestGreatestCommonDenominatorLib
{
    public class FractionOperations
    {
        
        public static int GetLeastCommonDenominator(int x, int y)
        {
            int max;
            int min;
            if (x > y){
                max = x; 
                min = y;
            }
            else{
                max = y; 
                min = x;
            }

            for (int i = 1; i < min; i++)
            {
                if ((max * i) % min == 0)
                {
                    return i * max;
                }
            }

            return max * min;
        }

        public static int GetGreatestCommonDivisor(int[] integerSet)
        {
            return integerSet.Aggregate(GetGreatestCommonDivisor);
        }   
        
        private static int GetGreatestCommonDivisor(int a, int b) {
            return b == 0 ? a : GetGreatestCommonDivisor(b, a % b);
        }
    }
}