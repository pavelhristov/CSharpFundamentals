﻿using System;
using System.Numerics;

class CalculateThree
{
   static void Main()
   {
      //input
      int N = int.Parse(Console.ReadLine());
      int K = int.Parse(Console.ReadLine());


      //logic
      BigInteger facturielN = 1;
      BigInteger facturielK = 1;
      BigInteger facturielNK = 1;

      for (int i = 1; i <= Math.Max(N, K); i++)
      {
         if (N >= i)
         {
            facturielN *= i;
         }
         if (K >= i)
         {
            facturielK *= i;
         }
         if (N-K >=i)
         {
            facturielNK *= i;
         }
      }
      BigInteger result = facturielN / (facturielK*facturielNK);

      //output
      Console.WriteLine(result);
   }
}