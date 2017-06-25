using System.Collections.Generic;

namespace FibonacciSequenceLib
{
    public class FibonacciSequenceUtility
    {
        public static int  CalculateFibonacciSeriesOfGivenLengthIterative(int length){
            int first = 0;
            int second = 1; 
            int result = 0;
            
            if (length == 0)
            {
                return 0;
            }
            if (length == 1)
            {
                return 1;
            }
   
   
            for (int i = 2; i <= length; i++)  
            {  
                result = first + second;  
                first = second;  
                second = result;  
            }  
   
            return result;  
        }

        public static int CalculateFibonacciSeriesOfGivenLengthRecursive(int length){  
            if (length == 0) return 0;  
            if (length == 1) return 1;
            return CalculateFibonacciSeriesOfGivenLengthRecursive(length - 1) 
                    + CalculateFibonacciSeriesOfGivenLengthRecursive(length - 2);  
        }

        public static IEnumerable<int> CalculateFibonacciSeriesWithYield() { 
            int first = 0;
            int second = 1; 
            int result = 0;

            yield return first; 
            while(first < int.MaxValue - second){ 
                yield return second; 
                result = first+second; 
                first = second; 
                second = result; 
                } 
        } 
    }
}