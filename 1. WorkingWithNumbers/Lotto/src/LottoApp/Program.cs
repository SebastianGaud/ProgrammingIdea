using System;
using System.Collections.Generic;
using System.Linq;
using LottoLib;

namespace LottoApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var flag = true;
            while (flag)
            {
                Console.WriteLine("0. Exit Game");
                Console.WriteLine("1. New Game");
                var key = Console.ReadKey();

                switch (key.KeyChar)
                {
                    case '0':
                        Console.Clear();
                        System.Console.WriteLine("Thank you for playing!\n\n");
                        return;
                    case '1':
                        Console.Clear();
                        var game = SetGame();
                        PlayGame(game);
                        Console.Clear();
                        break;
                    default:
                        Console.Clear();
                        System.Console.WriteLine("Can't understand this value, please retry!\n\n");
                        break;
                }
            }
        }

        private static void PlayGame(GameController game)
        {   
            if (game == null)
            {
                throw new ArgumentException();
            }
            var flag = true;

            while (flag)
            {
                Console.WriteLine("0. Exit");
                Console.WriteLine("1. Choose Numbers");
                Console.WriteLine("2. Play");
                Console.WriteLine("3. Visualize PrizePool");
                Console.WriteLine("4. Visualize Cash");
                var key = Console.ReadKey();

                switch (key.KeyChar)
                {
                    case '0':
                        Console.Clear();
                        flag = false;
                        return;
                    case '1':
                        Console.Clear();

                        System.Console.WriteLine("Insert " + game.HowMuchNumber + " numbers, separeted by : '-' \nThe numbers are in range 0 to 100: ");
                        game.Gamer.ProvidedNumbers =  ChooseNumbers();
                        break;
                    case '2':
                        Console.Clear();
                        var round = game.MakeRound();

                        System.Console.WriteLine("The numbers choose by game are: " + game.GetNumbersExctracted());

                        if (game.Gamer.ProvidedNumbers == null || game.Gamer.ProvidedNumbers.Count == 0)
                        {
                            System.Console.WriteLine("You must choose your numbers first");
                            break;
                        }
                        if(round){
                            System.Console.WriteLine("You won: " +  game.PrizePool.PrizePoolValue);
                            break;
                        }else
                        {
                            System.Console.WriteLine("You Lose your quote: " + game.PrizePool.GameQuote + "\n");
                            if (game.Gamer.Cash < 0)
                            {
                                System.Console.WriteLine("You've finished the money \n\n");
                                return;
                            }
                            System.Console.WriteLine("Now you have: " + game.Gamer.Cash);
                        }
                        break;
                    case '3':
                        Console.Clear();

                        System.Console.WriteLine("Prize Pool: " + game.PrizePool.PrizePoolValue);
                        break;
                    case '4':
                        Console.Clear();

                        System.Console.WriteLine("Now you have : " + game.Gamer.Cash);
                        break;
                }
            }
        }

        private static List<int> ChooseNumbers()
        {
            var numbers = Console.ReadLine();
            return numbers.Trim().Split('-').Select(Int32.Parse).ToList();
        }

        private static GameController SetGame()
        {
            Console.Clear();

            System.Console.WriteLine("What is your name? ");
            var name = Console.ReadLine();
            Console.Clear();


            System.Console.WriteLine("With how much numbers do you want to play? : ");
            var howMuchNumber = Convert.ToInt32(Console.ReadLine());
            Console.Clear();

            System.Console.WriteLine("Set prize Pool:  ");
            var prizePoolvalue = Convert.ToDecimal(Console.ReadLine());
            Console.Clear();

            System.Console.WriteLine("Set Game quote:  ");
            var gameQuote = Convert.ToDecimal(Console.ReadLine());
            Console.Clear();

            System.Console.WriteLine("With how much cash do you want to start?  ");
            var gamerCash = Convert.ToDecimal(Console.ReadLine());
            Console.Clear();

            Gamer gamer = new Gamer(){
                Name = name,
                Cash = gamerCash
            };
            PrizePool prizePool = new PrizePool(prizePoolvalue, gameQuote);

            return new GameController(prizePool, gamer, howMuchNumber);
        }
    }
}
