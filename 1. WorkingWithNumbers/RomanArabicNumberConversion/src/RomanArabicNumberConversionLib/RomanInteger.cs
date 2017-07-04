using System;
using System.Collections.Generic;
using System.Linq;

namespace RomanArabicNumberConversionLib
{
    public class RomanInteger
    {
        public string RomanNumerString { get; set; }
        public int RomanNumberValue { get; set; }

        public RomanInteger(string romanInteger)
        {
            romanInteger = romanInteger.Trim();
            if(RomanIntegerIsValid(romanInteger)){
                this.RomanNumerString = romanInteger.ToUpper();
                this.RomanNumberValue = 
                    ConvertListOfRomanDigitToArabicNumber(ExtractFromStringArabicValue(this.RomanNumerString));
            }
            else
            {
                throw new InvalidCastException();
            }
        }

		public static bool RomanIntegerIsValid(string romanInteger)
		{
			bool containsDigit = romanInteger.All(char.IsDigit);
            bool containsSymbol = romanInteger.All(char.IsSymbol);
            bool containsControl = romanInteger.All(char.IsControl);

            if (!containsControl && !containsDigit && !containsSymbol)
            {
                return true;                
            }
            else
            {
                return false;
            }
		}

        private static List<int> ExtractFromStringArabicValue(string romanNumber){
            var listOfArabianDigits = new List<int>();
            if (!RomanInteger.RomanIntegerIsValid(romanNumber))
            {
                throw new ArgumentException();
            }
            foreach (char romanDigit in romanNumber)
            {
                RomanNumber temp = (RomanNumber) Enum.Parse(typeof(RomanNumber), romanDigit.ToString());
                switch (temp)
                {
                    case RomanNumber.I:
                        listOfArabianDigits.Add((int)RomanNumber.I);
                        break;
                    case RomanNumber.V:
                        listOfArabianDigits.Add((int)RomanNumber.V);
                        break;
                    case RomanNumber.X:
                        listOfArabianDigits.Add((int)RomanNumber.X);
                        break;
                    case RomanNumber.L:
                        listOfArabianDigits.Add((int)RomanNumber.L);
                        break;
                    case RomanNumber.C:
                        listOfArabianDigits.Add((int)RomanNumber.C);
                        break;
                    case RomanNumber.D:
                        listOfArabianDigits.Add((int)RomanNumber.D);
                        break;
                    case RomanNumber.M:
                        listOfArabianDigits.Add((int)RomanNumber.M);
                        break;
                    default:
                        throw new InvalidCastException();
                }
            }

            return listOfArabianDigits;
        }

        private static int ConvertListOfRomanDigitToArabicNumber(List<int> romanNumberFromString){
            var arabicNumber = 0;

            for (int i = 0; i < romanNumberFromString.Count; i++)
            {
                if ((i+1) >= romanNumberFromString.Count)
                {
                    arabicNumber += romanNumberFromString[i];
                    return arabicNumber;
                }
                
                if (romanNumberFromString[i] >= romanNumberFromString[i+1])
                {
                    arabicNumber += romanNumberFromString[i];
                }
                else
                {
                    arabicNumber -= romanNumberFromString[i];
                }
            }

            return arabicNumber;
        }

        public static int ConvertRomanToArabic(string romanNumber){
            return ConvertListOfRomanDigitToArabicNumber(ExtractFromStringArabicValue(romanNumber));
        }

        public override string ToString(){
            return RomanNumerString;
        }
	}
}