namespace CoinFlipLib
{
    public class Coin
    {
        public bool Head { get; set; }
        public bool Tail { get; set; }

        public Coin()
        {
            this.Head = false;
            this.Tail = false;
        }

        public override string ToString(){
            if (Head == false && Tail == false)
            {
                return "The coin isn't flipped Yet.";
            }

            return Head == false? "Head" : "Tails";
        }
    }
}