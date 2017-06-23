using System;
using System.Collections.Generic;

namespace HappyNumbersLib
{
    public static class HappyNumbersUtility
    {
        private static List<int> ConvertNumberToListOfItsDigits(int number)
        {

            List<int> listOfInts = new List<int>();
            while (number > 0)
            {
                listOfInts.Add(number % 10);
                number = number / 10;
            }
            listOfInts.Reverse();
            return listOfInts;
        }

        private static IEnumerable<int> CalculatePowOfItsDigits(int number)
        {
            var digitsOfNumber = ConvertNumberToListOfItsDigits(number);

            foreach (var num in digitsOfNumber)
            {
                yield return (int) Math.Pow(num, 2);
            }
        }

        public static bool IsHappyNumber(int number){
            int? sumOfNumber = null;
            
            foreach (var num in CalculatePowOfItsDigits(number))
            {
                sumOfNumber += num;
            }

            return sumOfNumber == 1 ? true : false;
        }
    }

}