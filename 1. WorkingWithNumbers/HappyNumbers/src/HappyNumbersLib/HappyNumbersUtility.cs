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
            var list = new List<int>();
            foreach (var num in digitsOfNumber)
            {
                list.Add((int) Math.Pow(num, 2));
            }

            return list;
        }

        public static bool? IsHappyNumber(int number, ref int firstNumber, ref int numberOfIteration){
            int sumOfNumber = 0;

            if (numberOfIteration == 0)
            {
                firstNumber = number;
                numberOfIteration++;
            }

            foreach (var num in CalculatePowOfItsDigits(number))
            {
                sumOfNumber += num;
                if (sumOfNumber == firstNumber)
                {
                    return null;
                }
            }
            if (sumOfNumber == 1)
            {
                return true;
            }
            else
            {
                if (numberOfIteration > 50)
                {
                    return null;
                }
                numberOfIteration++;
                return IsHappyNumber(sumOfNumber, ref firstNumber, ref numberOfIteration);
            }
        }
    }

}