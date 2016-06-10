using System;
using System.Numerics;

class MutantSquirrels
{
   static void Main()
   {
      //input
      ulong t = ulong.Parse(Console.ReadLine());
      ulong b = ulong.Parse(Console.ReadLine());
      ulong s = ulong.Parse(Console.ReadLine());
      ulong n = ulong.Parse(Console.ReadLine());

      //logic
      double result = 0;
      BigInteger totalTails = t * b * s * n;

      if (totalTails%2==0)
      {
         result = (double)(totalTails * 376439);
      }
      else
      {
         result = (double)(totalTails) / 7;
      }
      //output
      Console.WriteLine("{0:F3}",result);
   }
}