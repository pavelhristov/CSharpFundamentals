using System;
using System.Linq;

class OddAndEvenProduct
{
   static void Main()
   {
      //input
      int N = int.Parse(Console.ReadLine());
      string strNumubers = Console.ReadLine();

      //logic
      int[] numbers = strNumubers.Split(' ').Select(int.Parse).ToArray();
      long oddSum = 1;
      long evenSum = 1;
      int counter = 1;

      foreach (var item in numbers)
      {
         if (counter % 2 == 0)
         {
            evenSum *= item;
         }
         else
         {
            oddSum *= item;
         }
         counter++;
      }

      //output 

      if (evenSum == oddSum)
      {
         Console.WriteLine("yes {0}", evenSum);
      }
      else
      {
         Console.WriteLine("no {0} {1}", oddSum, evenSum);
      }
   }
}