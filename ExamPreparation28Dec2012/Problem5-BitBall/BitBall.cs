using System;

class BitBall
{
   static void Main()
   {
      //input
      int[] n = new int[16];
      for (int i = 0; i < 16; i++)
      {
         n[i] = int.Parse(Console.ReadLine());
      }

      //logic
      char[,] table = new char[8, 8];

      for (int i = 0; i < 16; i++)
      {
         char[] bits = Convert.ToString(n[i], 2).PadLeft(8, '0').ToCharArray();
         for (int j = 0; j < 8; j++)
         {
            if ((i < 8) && (bits[j] == '1'))
            {
               table[i, j] = 'T';
            }
            else if ((i >= 8) && (bits[j] == '1'))
            {
               if ((table[i - 8, j] != 'T'))
               {
                  table[i - 8, j] = 'B';
               }
               else if ((table[i - 8, j] == 'T'))
               {
                  table[i - 8, j] = '\0';
               }
            }
         }
      }

      int countT = 0;
      int countB = 0;

      for (int j = 0; j < 8; j++)
      {
         bool flagT = false;
         bool flagB = false;
         bool checkB = true;

         for (int i = 0; i < 8; i++)
         {
            if (table[i, j] == 'T')
            {
               flagT = true;
            }
            else if (table[i, j] == 'B')
            {
               if (!flagT && checkB)
               {
                  flagB = true;
               }
               flagT = false;
               checkB = false;
            }
         }
         if (flagT)
         {
            countT++;
         }
         if (flagB)
         {
            countB++;
         }
      }
      //output
      Console.WriteLine("{0}:{1}", countT, countB);
   }
}