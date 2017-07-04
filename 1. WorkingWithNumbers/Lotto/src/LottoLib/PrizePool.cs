namespace LottoLib
{
    public class PrizePool
    {
        public decimal PrizePoolValue { get; private set; }
        public decimal GameQuote { get; private set; }
        public PrizePool(decimal prizePoolValue, decimal gameQuote)
        {
            this.PrizePoolValue = prizePoolValue;
            this.GameQuote = gameQuote;
        }
    }
}