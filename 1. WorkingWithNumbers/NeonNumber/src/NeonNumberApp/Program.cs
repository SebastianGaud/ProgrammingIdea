using System;
using NeonNumberLib;

namespace NeonNumberApp
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Insert number and i tell you if it's neon");
            var num = Convert.ToInt32(Console.ReadLine());
            var isNeon = NeonNumberUtility.IsNeonNumber(num);
            System.Console.WriteLine("Is neon number? : " + isNeon);
        }
    }
}
