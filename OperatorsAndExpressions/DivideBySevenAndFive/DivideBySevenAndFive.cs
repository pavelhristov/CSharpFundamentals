using System;
class DivideBySevenAndFive
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());
        if((number%7==0) && (number % 5==0))
        {
            Console.WriteLine("true {0}",number);
        }
        else
        {
            Console.WriteLine("false {0}",number);
        }
    }
}