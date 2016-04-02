using System;
class PrintTheASCIITable
{
    static void Main()
    {
        char c = '\0';
        for (int i = 33; i <= 126; i++)
        {
            c = (char)i;
            Console.Write(c);
        }
    }
}

