using System.Numerics;

namespace FibonacciNumberFinder
{
    public interface IFibonacciNumberCalculator
    {
        BigInteger FindNthNumberUsingAForLoop(int indexInFibonacciSequence);

        int FindNthNumberUsingRecursion(int indexInFibonacciSequence);
    }
}
