using System;
class Rectangles
{
    static void Main()
    {
        double width = double.Parse(Console.ReadLine());
        double height = double.Parse(Console.ReadLine());
        double area = width * height;
        double perimeter = (2 * width) + (2 * height);
        Console.WriteLine("{0:0.00} {1:0.00}",area,perimeter);
    }
}

