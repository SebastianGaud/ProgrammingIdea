using System;
using System.Linq;
using FibonacciSequenceLib;
namespace FibonacciSequenceApp
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Choose how to calculate Fibonacci Series");
            
            System.Console.WriteLine("1. Calculate Fibonacci Series with iterative Approach");
            System.Console.WriteLine("2. Calculate Fibonacci Series with recursive approach");
            System.Console.WriteLine("3. Calculate Fibonacci Series with Linq Query");
            var choice = Console.ReadKey();
            
            if (!char.IsDigit(choice.KeyChar))
            {
                Console.WriteLine("Can't understand this choice");
                Environment.Exit(exitCode: 1);
            }

            switch (int.Parse(choice.KeyChar.ToString()))
            {
                case 1 :
                    CalculateFibonacciIterative();
                    break;
                case 2:
                    CalculateFibonacciRecursive();
                    break;
                case 3: 
                    CalculateFibonacciWithLinqQuery();
                    break;
                default:
                    System.Console.WriteLine("Can't understand this choice");
                    return;
            }
            
        }

        public static void CalculateFibonacciIterative(){
            Console.Write("Enter the length of the Fibonacci Series: ");  
            int length = Convert.ToInt32(Console.ReadLine());  
   
            for (int i = 0; i < length; i++)  
            {  
                Console.Write("{0} ", FibonacciSequenceUtility.CalculateFibonacciSeriesOfGivenLengthIterative(i));  
            } 
            Environment.Exit(exitCode: 0);
        }

        public static void CalculateFibonacciRecursive(){
            Console.Write("Enter the length of the Fibonacci Series: ");  
            int length = Convert.ToInt32(Console.ReadLine());  
            for (int i = 0; i < length; i++)  
            {  
                Console.Write("{0} ", FibonacciSequenceUtility.CalculateFibonacciSeriesOfGivenLengthRecursive(i));  
            } 
            Environment.Exit(exitCode: 0);
        }

        public static void CalculateFibonacciWithLinqQuery(){
            Console.Write("Enter the length of the Fibonacci Series: ");  
            int length = Convert.ToInt32(Console.ReadLine());  

            FibonacciSequenceUtility.CalculateFibonacciSeriesWithYield()
                .Where(x=> x < length)
                .ToList()
                .ForEach(i=> Console.Write("{0} ", i));
            Environment.Exit(exitCode: 0);
        }
    }
}
