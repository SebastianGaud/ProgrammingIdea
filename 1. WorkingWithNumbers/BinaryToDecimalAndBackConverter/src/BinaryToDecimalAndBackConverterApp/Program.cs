using System;
using BinaryToDecimalAndBackConverterLib;

namespace BinaryToDecimalAndBackConverterApp
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Insert Number in banary format: ");
            var binary = Console.ReadLine();
            System.Console.WriteLine("Insert decimal number");
            var dec = Convert.ToInt32(Console.ReadLine());


            System.Console.WriteLine("Convert with easy way decimal to binary: " + ConvertBinary.ConverterDecimalToBinary(dec));
            System.Console.WriteLine("Convert with hard way decimal to binary: " + ConvertBinary.CovnertDecimalToBinaryHardWay(dec));
            System.Console.WriteLine("Convert with easy way binary to decimal: " + ConvertDecimal.ConvertBinaryToDecimal(binary));
            System.Console.WriteLine("Convert with hard way binary to decimal: " + ConvertDecimal.ConvertBinaryToDecimal(binary));
        }
    }
}
