using System;

class ThirdDigit
{
    static void Main()
    {
        uint N = uint.Parse(Console.ReadLine());
        if (N < 100)
        {
            Console.WriteLine("false 0");
        }
        else
        { 
            string str = N.ToString();
            char[] b = str.ToCharArray(0, str.Length);
            if (b[str.Length - 3] == '7')
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("false {0}", b[str.Length - 3]);
            }
        }
    }
}