﻿using System;
class BitExchange
{
   static void Main()
   {
      uint N = uint.Parse(Console.ReadLine());
      uint mask;
      uint nAndMask;
      uint mask1;
      uint nAndMask1;
      uint bit;
      uint bit1;

      for (int i = 3; i < 6; i++)
      {
         mask = (uint)1 << i;
         nAndMask = N & mask;
         bit = nAndMask >> i;
         if (bit == 0)
         {
            mask1 = (uint)1 << i + 21;
           
            nAndMask1 = N & mask1;
            bit1 = nAndMask1 >> i;
            if (bit1==0)
            {
               mask = (uint)1 << i;
               N = N & (~mask);
            }
            else
            {
               mask = (uint)1 << i;
               N = N | mask;
            }
            N = N & (~mask1);
         }
         else
         {
            mask1 = (uint)1 << i + 21;
            
            nAndMask1 = N & mask1;
            bit1 = nAndMask1 >> i;
            if (bit1 == 0)
            {
               mask = (uint)1 << i;
               N = N & (~mask);
            }
            else
            {
               mask = (uint)1 << i;
               N = N | mask;
            }
            N = N | mask1;
         }
      }
      Console.WriteLine(N);
   }
}
