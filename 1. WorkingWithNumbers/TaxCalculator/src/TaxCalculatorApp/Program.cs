using System;
using TaxCalculatorLib;

namespace TaxCalculatorApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Give me a Price!");
            double price = Convert.ToDouble(Console.ReadLine());
            System.Console.WriteLine("Give some Tax");
            double tax = Convert.ToDouble(Console.ReadLine());

            Console.ForegroundColor = ConsoleColor.Blue;
            System.Console.WriteLine("The price with tax added is: "+ TaxUtility.AddTaxToPrice(price, tax));
            Console.ResetColor();
        }
    }
}
