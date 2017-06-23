using System;

namespace CoinFlipLib
{
    public class CoinFlipUtility
    {
        Random rand = new Random();
        public Coin coin { get; set; }
        public int NumberOfTails { get; set; }  
        public int NumberOfHeads { get; set; }

        public CoinFlipUtility(Coin coin)
        {
            this.coin = coin;
        }

        public void FlipCoin(){
            var n = rand.Next(0, 100);

            if (n >= 50 && n <= 100)
            {
                NumberOfHeads++;
                coin.Head = true;
                coin.Tail = false;
            }
            else if (n >= 0 && n <= 49 ) 
            {
                NumberOfTails++;
                coin.Head = false;
                coin.Tail = true;
            }
        }
    }
}