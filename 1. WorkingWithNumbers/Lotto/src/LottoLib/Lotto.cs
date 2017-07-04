using System;
using System.Collections.Generic;

namespace LottoLib
{
    public class Lotto
    {
        private Random rand = new Random();
        public List<int> ExtractedNumber { get; set; }

        public Lotto(int howMuchNumbers)
        {
            ExtractedNumber = GenerateLottoNumbers(howMuchNumbers);
        }
        public string GetExtractedNumberAsFormattedString(){
            return string.Join(",", ExtractedNumber);
        }

        public List<int> GenerateLottoNumbers(int howMuchNumbers){

            var numbers = new List<int>();
            for (int i = 0; i < howMuchNumbers; i++)
            {
                var randomNumber = rand.Next(1, 100);
                if (numbers.Contains(randomNumber))
                {
                    i = i-1;
                }else{
                    numbers.Add(randomNumber);
                }
            }

            return numbers;
        }
    }
}