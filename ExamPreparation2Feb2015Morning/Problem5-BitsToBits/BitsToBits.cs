using System;

class BitsToBits
{
   static void Main()
   {
      //input & logic
      int N = int.Parse(Console.ReadLine());

      int maxZeroCount = 0;
      int currentZeroCount = 0;

      int maxOneCount = 0;
      int currentOneCount = 0;

      int lastBit = 5555;

      for (int i = 0; i < N; i++)
      {
         int num = int.Parse(Console.ReadLine());
         for (int j = 29; j >= 0; j--)
         {
            int bit = ((1 << j) & num) >> j;
            if (bit == 1)
            {
               if (lastBit==1)
               {
                  currentOneCount++;
               }
               else
               {
                  maxZeroCount = Math.Max(maxZeroCount, currentZeroCount);
                  currentZeroCount = 0;
                  currentOneCount = 1;
               }
            }
            else if (lastBit==0)
            {
               currentZeroCount++;
            }
            else
            {
               maxOneCount = Math.Max(maxOneCount, currentOneCount);
               currentOneCount = 0;
               currentZeroCount = 1;
            }
            lastBit = bit;
         }

      }

      maxZeroCount = Math.Max(maxZeroCount, currentZeroCount);
      maxOneCount = Math.Max(maxOneCount, currentOneCount);
      //output
      Console.WriteLine(maxZeroCount);
      Console.WriteLine(maxOneCount);
   }
}