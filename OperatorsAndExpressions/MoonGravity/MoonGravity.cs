using System;
class Program
{
    static void Main()
    {
        double W = double.Parse(Console.ReadLine());
        double W2 = (W*17)/100;
        Console.WriteLine("{0:0.000}", W2);
    }
}