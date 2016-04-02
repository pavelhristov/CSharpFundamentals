using System;
using System.IO;

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
            char[] b = new char[str.Length];
            using (StringReader sr = new StringReader(str))
            {
                sr.Read(b, 0, str.Length);
            }
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