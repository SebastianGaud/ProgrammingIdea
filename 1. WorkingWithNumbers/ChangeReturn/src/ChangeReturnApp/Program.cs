using System;
using ChangeReturnLib;

namespace ChangeReturnApp
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Type price of an item");
            var price = Convert.ToDecimal(Console.ReadLine());

            System.Console.WriteLine("How much customer give you?");
            var customerPay = Convert.ToDecimal(Console.ReadLine());

            var listOfAllCoinsChange = ChangeUtility.GetChange(customerPay-price);

            System.Console.WriteLine($"The difference between price and customer money is: {customerPay-price}");

            System.Console.WriteLine("You must give to the customer: ");
            System.Console.WriteLine(String.Format("{0} Pieces of {1}", listOfAllCoinsChange[CoinsEnum.Penny], CoinsEnum.Penny));
            System.Console.WriteLine(String.Format("{0} Pieces of {1}", listOfAllCoinsChange[CoinsEnum.Nickel], CoinsEnum.Nickel));
            System.Console.WriteLine(String.Format("{0} Pieces of {1}", listOfAllCoinsChange[CoinsEnum.Dime], CoinsEnum.Dime));
            System.Console.WriteLine(String.Format("{0} Pieces of {1}", listOfAllCoinsChange[CoinsEnum.Quarter], CoinsEnum.Quarter));
            System.Console.WriteLine(String.Format("{0} Pieces of {1}", listOfAllCoinsChange[CoinsEnum.Dollar], CoinsEnum.Dollar));
        }
    }
}
