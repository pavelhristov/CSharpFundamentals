using System;
class PointCircleRectangle
{
    static void Main()
    {
        double x = double.Parse(Console.ReadLine());
        double y = double.Parse(Console.ReadLine());
        double distance = Math.Sqrt(Math.Pow(x-1, 2) + Math.Pow(y-1, 2));

        if (distance<=(1.5*1.5))
        {
            Console.Write("inside circle ");
        }
        else
        {
            Console.Write("outside circle ");
        }
        if ((x <= 2) && (x >= -4))
        {
            if ((y <= 2) && (y >= 0))
            {
                Console.WriteLine("inside rectangle");
            }
            else
            {
                Console.WriteLine("outside rectangle");
            }
        }
        else
        {
            Console.WriteLine("outside rectangle");
        }
    }
}

