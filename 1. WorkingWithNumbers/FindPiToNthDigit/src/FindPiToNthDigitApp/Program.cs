using System;
using FindPiToNthDigitLib;

namespace FindPiToNthDigitApp
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Insert numbers of PI Digits");
            System.Console.WriteLine(
                PiUtility.CalculatePi(
                    Convert.ToInt32(
                        Console.ReadLine()))
                .Insert(1, ",")
            );
        }
    }
}
