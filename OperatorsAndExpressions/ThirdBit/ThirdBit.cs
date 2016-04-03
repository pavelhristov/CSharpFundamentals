using System;
class ThirdBit
{
    static void Main()
    {
        int a = int.Parse(Console.ReadLine());
        int p = 3;
        int mask = 1 << p;
        int aAndMask = a & mask;
        int bit = aAndMask >> p;
        Console.WriteLine(bit);
    }
}
