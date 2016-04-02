using System;

class Age
{
    static void Main()
    {
        String b = "";
        b = Console.ReadLine();
        DateTime a = Convert.ToDateTime(b);
        DateTime c = DateTime.Now;
        int y = c.Year - a.Year;
        int m = c.Month - a.Month;
        int d = c.Month - a.Month;
        int age = 0;
        if (y >= 0)
        {
            if (m >= 0)
            {
                if (d >= 0)
                {
                    age = y;
                    Console.WriteLine(age);
                }
                else
                {
                    age = y - 1;
                    Console.WriteLine(age);
                }
            }
            else
            {
                age = y - 1;
                Console.WriteLine(age);
            }
        }
        Console.WriteLine(age+10);

    }
}

