using System;

class FourDigits
{
    static void Main()
    {
        int abcd = int.Parse(Console.ReadLine());
        string str = abcd.ToString();
        char[] b = new char[4];
        b = str.ToCharArray(0, 4);
        int sum = 0;
        foreach (char w in b)
        {
            sum += Convert.ToInt32(w.ToString());
        }
        Console.WriteLine(sum);

        Array.Reverse(b);
        Console.WriteLine(b);

        char[] c = str.ToCharArray(0, 4);
        char v=c[3];

        for (int i = 3; i >= 0; i--) 
        {
            if (i==0)
            {
                c[i] = v;
            }
            else
            {
                c[i] = c[i - 1];
            }
        }
        Console.WriteLine(c);

        char a = b[0];
        b[0] = b[3];
        b[3] = Convert.ToChar(a);
        Console.WriteLine(b);

    }
}

