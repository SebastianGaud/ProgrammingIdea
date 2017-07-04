using System;
using System.Collections.Generic;


namespace LottoLib
{
    public class Gamer
    {
        public string Name { get; set; }
        public decimal Cash { get; set; }
        public List<int> ProvidedNumbers { get; set; }

        public Gamer()
        {
            
        }

        public Gamer(List<int> providedNumbers)
        {
            this.ProvidedNumbers = providedNumbers;
        }

        public void ProvideNumbersForGamer(List<int> providedNumbers){
            if (providedNumbers.Count > 6)
            {
                throw new ArgumentException("Value is not valid");
            }
            this.ProvidedNumbers = providedNumbers;
        }
    }
}