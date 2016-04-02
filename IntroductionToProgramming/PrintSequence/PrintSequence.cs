using System;

class PrintSequence
{
    static void Main()
    {
        int a = 0;
        for(int i=2; i<=11; i=i+1)
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