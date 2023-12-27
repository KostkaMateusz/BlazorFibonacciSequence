using System.Numerics;

namespace FibonacciSeriesCalculator;

public static class FibbonaciCalculator
{
    public static IEnumerable<(uint, BigInteger)> FibonacciIterative(uint len)
    {
        BigInteger a = new(0);
        BigInteger b = new(1);
        BigInteger c = new(0);

        yield return (0, a);
        yield return (1, b);

        for (uint i = 2; i <= len; i++)
        {
            c = a + b;
            yield return (i, c);
            a = b;
            b = c;
        }
    }
}