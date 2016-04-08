using System;
class BitExchange
{
   static void Main()
   {
      int N = int.Parse(Console.ReadLine());
      int mask;
      int nAndMask;
      int bit;
      int result;

      for (int i = 3; i < 6; i++)
      {
         mask = 1 << i;
         nAndMask = N & mask;
         bit = nAndMask >> i;

      }
   }
}
