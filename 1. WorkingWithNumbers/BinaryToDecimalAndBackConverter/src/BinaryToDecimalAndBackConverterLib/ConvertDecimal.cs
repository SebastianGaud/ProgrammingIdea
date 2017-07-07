using System;
using System.Collections.Generic;
using System.Linq;

namespace BinaryToDecimalAndBackConverterLib
{
    public class ConvertDecimal
    {
        //Easy Way
        public static int ConvertBinaryToDecimal(string binary)
            => Convert.ToInt32(binary, 2); 

        //HardWay
        public static int ConvertBinaryToDecimalHardWay(string binary)
        {
            var list = binary.Select(x => Int32.Parse(x.ToString())).Reverse().ToList();
            
            for (int i = 0; i < list.Count(); i++)
            {
                var val = list[i];

                val = val * 2 * i;

                list[i] = val;
            }

            return list.Sum();

        }
    }
}