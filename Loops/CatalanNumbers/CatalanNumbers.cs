using System;
using System.Numerics;

class CatalanNumbers
{
   static void Main()
   {
      //input
      int N = int.Parse(Console.ReadLine());

      //logic
      BigInteger facturielN = 1;
      BigInteger facturiel2N = 1;
      BigInteger facturielNextN = 1;

      for (int i = 1; i <= 2*N; i++)
      {
         if (N >= i)
         {
            facturielN *= i;
         }
         if (2*N >= i)
         {
            facturiel2N *= i;
         }
         if (N +1  >= i)
         {
            facturielNextN *= i;
         }
      }
      BigInteger result = facturiel2N / (facturielNextN * facturielN);

      //output
      Console.WriteLine(result);
   }
}