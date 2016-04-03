using System;
using System.Numerics;
class NthBit
{
    static void Main()
    {
        BigInteger P = BigInteger.Parse(Console.ReadLine());
        byte N = byte.Parse(Console.ReadLine());
        int mask = 1 << N;
        BigInteger pAndMask = P & mask;
        BigInteger bit = pAndMask >> N;
        Console.WriteLine(bit);
    }
}
