using System;

class LongSequence
{
    static void Main()
    {
        int a = 0;
        for (int i = 2; i <= 1001; i = i + 1)
        {
            a = i % 2;
            if (a == 0)
            {
                Console.WriteLine(i);
            }
            else
            {
                Console.WriteLine(-i);
            }
        }
    }
}