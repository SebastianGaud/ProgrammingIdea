using System;
using System.Linq;
using LottoLib;

namespace LottoApp
{
    public class GameController
    {
        public int HowMuchNumber {  get; set; }
        private Lotto _numbers;
        public PrizePool PrizePool { get; private set; }
        public Gamer Gamer { get; private set; }

        public string GetNumbersExctracted(){
            return _numbers.GetExtractedNumberAsFormattedString();
        }
        public GameController(PrizePool prizePool, Gamer gamer, int howMuchNumber)
        {
            this.PrizePool = prizePool;
            this.Gamer = gamer;
            this.HowMuchNumber = howMuchNumber;
            this._numbers = new Lotto(this.HowMuchNumber);
        }

        public void NewGame(PrizePool prizePool, Gamer gamer, int howMuchNumber){

            this.PrizePool = prizePool;
            this.Gamer = gamer;
            this.HowMuchNumber = howMuchNumber;
            this._numbers = new Lotto(this.HowMuchNumber);
        }

        public void NewRound(){
            this._numbers = new Lotto(this.HowMuchNumber);
        }
        public bool MakeRound(){
            DetractGameQuoteFromGamerCash();
            var isWinner = CheckGamerNumbersWithLottoNumbers();
            CalculateGamerCashAfterRound(isWinner);
            return isWinner;
        }

        private void DetractGameQuoteFromGamerCash(){
            this.Gamer.Cash -= PrizePool.GameQuote;
        }
        private bool CheckGamerNumbersWithLottoNumbers(){
            NewRound();
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