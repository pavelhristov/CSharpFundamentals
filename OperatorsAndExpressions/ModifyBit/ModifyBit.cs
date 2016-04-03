using System;
class ModifyBit
{
    static void Main()
    {
        long N = long.Parse(Console.ReadLine());
        byte P = byte.Parse(Console.ReadLine());
        byte v = byte.Parse(Console.ReadLine());
        int mask;
        if (v == 0)
        {
            mask = ~(1 << P);
        }
        else
        {
            mask = 1 << P;
        }
        long nAndMask = N & mask;
        Console.WriteLine(nAndMask);
    }
}