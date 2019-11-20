using System;
using System.Numerics;

namespace FibonacciNumberFinder
{
    class Program
    {
        private readonly IFibonacciNumberCalculator fibonacciNumberCalculator;

        public Program()
        {
            fibonacciNumberCalculator = new FibonacciNumberCalculator();
        }

        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Enter the index of the number in the Fibonacci Sequence that you would like to calculate (or 'e' to exit):");

                string input = Console.ReadLine();

                if (input == "e")
                {
                    break;
                }
                
                var inputNumber = Int32.Parse(input);
                BigInteger? fibonacciNumber = null;

                IFibonacciNumberCalculator fibonacciNumberCalculator = new FibonacciNumberCalculator();
                fibonacciNumber = fibonacciNumberCalculator.FindNthNumberUsingAForLoop(inputNumber);

                Console.WriteLine($"The number in the sequence at position {inputNumber} is: {fibonacciNumber}");
            }
        }
    }
}
