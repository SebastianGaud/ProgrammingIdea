using System.Collections.Generic;
using System.Linq;

namespace NeonNumberLib
{
    public static class NeonNumberUtility
    {
        public static bool IsNeonNumber(int number){
            var digits = ConvertNumberToListOfItsDigits((number * number));
            if (digits.Sum() == number)
            {
                return true;
            }
            return false;
        }

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

        public static List<int> GetNNeonNumber(int n){
            var list =new  List<int>();
            for (int i = 0; i < n; i++)
            {
                if (IsNeonNumber(i))
                {
                    list.Add(i);
                }
            }


            return list;
        }
    }
}