﻿using System;

class BiggestOfThree
{
   static void Main()
   {
      double a = double.Parse(Console.ReadLine());
      double b = double.Parse(Console.ReadLine());
      double c = double.Parse(Console.ReadLine());

      if (a>b)
      {
         if (a>c)
         {
            Console.WriteLine(a);
         }
         else
         {
            Console.WriteLine(c);
         }
      }
      else if (b>a)
      {
         if (b>c)
         {
            Console.WriteLine(b);
         }
         else
         {
            Console.WriteLine(c);
         }
      }
      else
      {
         Console.WriteLine(c);
      }

   }
}
