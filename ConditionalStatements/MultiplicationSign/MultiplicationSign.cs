using System;

class MultiplicationSign
{
   static void Main()
   {
      double a = double.Parse(Console.ReadLine());
      double b = double.Parse(Console.ReadLine());
      double c = double.Parse(Console.ReadLine());

      double d = (a * b) * c;

      if (d>0)
      {
         Console.WriteLine('+');
      }
      else if (d<0)
      {
         Console.WriteLine('-');
      }
      else
      {
         Console.WriteLine(0);
      }
   }
}
