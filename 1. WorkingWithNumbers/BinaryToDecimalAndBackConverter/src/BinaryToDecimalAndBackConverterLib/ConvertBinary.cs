using System;
using System.Collections.Generic;

namespace BinaryToDecimalAndBackConverterLib
{
    public class ConvertBinary
    {
        //Easy Way
        public static string ConverterDecimalToBinary(int dec)
            => Convert.ToString(dec, 2);

        //Hard Way
        public static string CovnertDecimalToBinaryHardWay(int dec){
            var binaryNumbers = new List<int>();
            while (dec >= 1)
            {
                if (dec % 2 != 0)
                {
                    binaryNumbers.Add(1);
                    dec = dec /2 ;
                }
                else
                {
                    binaryNumbers.Add(0);
                    dec = dec /2 ;

                }
            }

            return string.Join("", binaryNumbers);
        }
    }
}