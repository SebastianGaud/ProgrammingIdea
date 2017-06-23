using System;
using HappyNumbersLib;

namespace HappyNumbersApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfIteration = 0;
            for (int i = 1; i < 1000; i++)
            {
                bool? isHappy = HappyNumbersUtility.IsHappyNumber(i, ref i, ref numberOfIteration);
                string message;
                if (isHappy == null)
                {
                    message = "Number of iteration before valuate this number as non Happy are : " + numberOfIteration +" iterations";
                }
                else{
                    message = isHappy.Value.ToString();
                }

                //Because i don't really want to see all non-Happy numbers! I make the code above this line only for
                //diagnostic porpouse.
                if (isHappy.HasValue? isHappy.Value : false)
                {
                    System.Console.WriteLine($"The number :  {i} is this number happy?  {message}");
                }
                numberOfIteration = 0;
            }
        }
    }
}
