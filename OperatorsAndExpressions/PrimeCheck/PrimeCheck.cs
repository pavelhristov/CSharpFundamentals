using System;

class PrimeCheck
{
    static void Main()
    {
        int N = int.Parse(Console.ReadLine());
        if (N <= 1)
        {
            Console.WriteLine("false");
        }
        else
        {
            int i = 2;
            if (N > i)
            {
                while ((i < N) && (N % i != 0))
                {
                    i++;
                }
                if (i == N)
                {
                    Console.WriteLine("true");
                }
                else
                {
                    Console.WriteLine("false");
                }
            }
            else
            {
                Console.WriteLine("true");
            }
        }
    }
}