using System;
using RomanArabicNumberConversionLib;

namespace RomanArabicNumberConversionApp
{
    class Program
    {
        static void Main(string[] args)
        {
            RomanInteger romanNumber;
            if (args.Length > 0)
            {
                 romanNumber = new RomanInteger(Convert.ToString(args[0]));
            }
            else
            {
                System.Console.WriteLine("Insert number in Roman Form");
                romanNumber = new RomanInteger(Console.ReadLine());
            }
            Console.ForegroundColor = ConsoleColor.Blue;
            System.Console.WriteLine("Roman number format: " + romanNumber);
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Red;
            System.Console.WriteLine("Arabic number format:  " + romanNumber.RomanNumberValue);
            Console.ResetColor();
        }
    }
}
