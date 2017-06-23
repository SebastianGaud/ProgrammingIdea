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

            var fact = FactorialFinderUtility.GetFactorialWithForCycle(n);

            System.Console.WriteLine("With For:");
            System.Console.WriteLine(fact);

            System.Console.WriteLine("With Recursion: ");
            System.Console.WriteLine(FactorialFinderUtility.GetFactorialWithRecursion(n));
        }
    }
}
