using System;
using LatestGreatestCommonDenominatorLib;

namespace LatestGreatestCommonDenominatorApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Fraction firstFraction = new Fraction();
            Fraction secondFraction = new Fraction();


            firstFraction.Denominator = 27;
            secondFraction.Denominator = 63;

            var greatestCommonDivisor = FractionOperations.GetGreatestCommonDivisor(new int[]{firstFraction.Denominator, secondFraction.Denominator});
            var leastCommonDenominator = FractionOperations.GetLeastCommonDenominator(firstFraction.Denominator, secondFraction.Denominator);


            System.Console.WriteLine("Gratest common Divisor: ");
            System.Console.WriteLine(greatestCommonDivisor);
            System.Console.WriteLine("Least common denominator: ");
            System.Console.WriteLine(leastCommonDenominator);
        }
    }
}
