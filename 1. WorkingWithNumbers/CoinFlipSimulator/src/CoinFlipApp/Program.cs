using System;
using System.Threading.Tasks;
using CoinFlipLib;

namespace CoinFlipApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Coin coin = new Coin();
            CoinFlipUtility flipUtility = new CoinFlipUtility(coin);
            
            while (true)
            {
                FlipCoin(flipUtility, coin);
                System.Threading.Thread.Sleep(1000);
            }
        }

        public static void FlipCoin(CoinFlipUtility flipUtility, Coin coin){
            flipUtility.FlipCoin();
            System.Console.WriteLine(coin);
            
            if (flipUtility.NumberOfHeads > flipUtility.NumberOfTails)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                System.Console.WriteLine("Number of Heads: "+ flipUtility.NumberOfHeads);
                Console.ForegroundColor = ConsoleColor.Red;
                System.Console.WriteLine("Number of tails: "+ flipUtility.NumberOfTails);
                Console.ResetColor();
            }                
            else if (flipUtility.NumberOfHeads < flipUtility.NumberOfTails)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                System.Console.WriteLine("Number of Heads: "+ flipUtility.NumberOfHeads);
                Console.ForegroundColor = ConsoleColor.Blue;
                System.Console.WriteLine("Number of tails: "+ flipUtility.NumberOfTails);
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                System.Console.WriteLine("Number of Heads: "+ flipUtility.NumberOfHeads);
                Console.ForegroundColor = ConsoleColor.Blue;
                System.Console.WriteLine("Number of tails: "+ flipUtility.NumberOfTails);
                Console.ResetColor();
            }
        }
    }
}
