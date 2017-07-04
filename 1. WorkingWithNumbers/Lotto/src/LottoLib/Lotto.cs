using System.Collections.Generic;

namespace LottoLib
{
    public class Lotto
    {
        public List<int> ExtractedNumber { get; set; }

        public string GetExtractedNumberAsFormattedString(){
            return string.Join(",", ExtractedNumber);
        }
    }
}