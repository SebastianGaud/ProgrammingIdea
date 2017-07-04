using System;
using System.Linq;
using LottoLib;

namespace LottoApp
{
    public class GameController
    {
        private Lotto _numbers;
        public PrizePool PrizePool { get; private set; }
        public Gamer Gamer { get; private set; }

        public GameController(PrizePool prizePool, Gamer gamer)
        {
            this.PrizePool = prizePool;
            this.Gamer = gamer;
            this._numbers = new Lotto();
            DetractGameQuoteFromGamerCash();
        }

        public void NewGame(PrizePool prizePool, Gamer gamer){

            this.PrizePool = prizePool;
            this.Gamer = gamer;
            this._numbers = new Lotto();
            DetractGameQuoteFromGamerCash();
        }
        
        public void NewRound(PrizePool prizePool){
            this.PrizePool = prizePool;
            this._numbers = new Lotto();
            DetractGameQuoteFromGamerCash();
        }
        public bool MakeRound(){
            var isWinner = CheckGamerNumbersWithLottoNumbers();
            CalculateGamerCashAfterRound(isWinner);
            return isWinner;
        }

        private void DetractGameQuoteFromGamerCash(){
            this.Gamer.Cash -= PrizePool.GameQuote;
        }
        private bool CheckGamerNumbersWithLottoNumbers(){
            if (this.Gamer.ProvidedNumbers != null && this._numbers.ExtractedNumber.Count == this.Gamer.ProvidedNumbers.Count)
            {
                return this._numbers.ExtractedNumber.All(this.Gamer.ProvidedNumbers.Contains);
            }

            return false;
        }

        private void CalculateGamerCashAfterRound(bool isWinner){
            if (isWinner)
                Gamer.Cash += PrizePool.PrizePoolValue;
        }

    }
}