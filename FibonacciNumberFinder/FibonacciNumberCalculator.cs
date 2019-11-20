using System;
using System.Numerics;

namespace FibonacciNumberFinder
{
    public class FibonacciNumberCalculator : IFibonacciNumberCalculator
    {
        // This approach can generate a number too large to fit in typical numeric types
        public BigInteger FindNthNumberUsingAForLoop(int indexInFibonacciSequence)
        {
            if (indexInFibonacciSequence < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(indexInFibonacciSequence), "Value must be greater than zero");
            }

            // handling the first two numbers in the sequence (0, 1) which are equal to f(n)
            // which cannot be found using the formula the rest of the numbers abide by: f(n) = f(n-1) + f(n-2)
            if (indexInFibonacciSequence < 2)
            {
                return indexInFibonacciSequence;
            }
            else
            {
                BigInteger currentFibonacciNumber = BigInteger.One; // initial value is f(2) in the Fibonacci Sequence
                BigInteger indexMinusOneValue = BigInteger.One; // initial value is f(1) in the Fibonacci Sequence
                BigInteger indexMinusTwoValue = BigInteger.Zero; // initial value is f(0) in the Fibonacci Sequence

                for (int i = 2; i <= indexInFibonacciSequence; i++)
                {
                    currentFibonacciNumber = indexMinusOneValue + indexMinusTwoValue;
                    indexMinusTwoValue = indexMinusOneValue;
                    indexMinusOneValue = currentFibonacciNumber;
                }

                return currentFibonacciNumber;
            }
        }

        // Calling this with larger numbers will cause a StackOverflow
        public int FindNthNumberUsingRecursion(int indexInFibonacciSequence)
        {
            if (indexInFibonacciSequence < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(indexInFibonacciSequence), "Value must be greater than zero");
            }

            // handling the first two numbers in the sequence (0, 1) which are equal to f(n)
            // which cannot be found using the formula the rest of the numbers abide by: f(n) = f(n-1) + f(n-2)
            if (indexInFibonacciSequence < 2)
            {
                return indexInFibonacciSequence;
            }
            else
            {
                return FindNthNumberUsingRecursion(indexInFibonacciSequence - 1) + FindNthNumberUsingRecursion(indexInFibonacciSequence - 2);
            }
        }
    }
}
