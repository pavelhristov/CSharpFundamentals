using System;

class BitSwap
{
   static void Main()
   {
      uint n = uint.Parse(Console.ReadLine());
      int p = int.Parse(Console.ReadLine());
      int q = int.Parse(Console.ReadLine());
      int k = int.Parse(Console.ReadLine());
      uint mask;
      uint nAndMask;
      uint mask1;
      uint nAndMask1;
      uint bit;
      uint bit1;

      for (int i = p; i < p + k; i++)
      {
         mask = (uint)1 << i;
         nAndMask = n & mask;
         bit = nAndMask >> i;
         if (bit == 0)
         {
            mask1 = (uint)1 << i + (q - p);

            nAndMask1 = n & mask1;
            bit1 = nAndMask1 >> i;
            if (bit1 == 0)
            {
               mask = (uint)1 << i;
               n = n & (~mask);
            }
            else
            {
               mask = (uint)1 << i;
               n = n | mask;
            }
            n = n & (~mask1);
         }
         else
         {
            mask1 = (uint)1 << i + (q - p);

            nAndMask1 = n & mask1;
            bit1 = nAndMask1 >> i;
            if (bit1 == 0)
            {
               mask = (uint)1 << i;
               n = n & (~mask);
            }
            else
            {
               mask = (uint)1 << i;
               n = n | mask;
            }
            n = n | mask1;
         }
      }
      Console.WriteLine(n);
   }
}