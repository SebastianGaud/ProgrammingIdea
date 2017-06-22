using System;
using FactorialFinderLib;

namespace FactorialFinderApp
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Give me a number!");
            var n = Convert.ToInt32(Console.ReadLine());

            var list = FactorialFinderUtility.GetFactorialWithForCycle(n);

            System.Console.WriteLine("With For:");
            //list.Reverse();
            for (int i = 0; i < list.Count; i++)
            {
                System.Console.WriteLine("Cycle number: " + (i).ToString() + "  "+ list[i]);
            }

            System.Console.WriteLine("With Recursion: ");
            FactorialFinderUtility.GetFactorialWithRecursion(n);
        }
    }
}
