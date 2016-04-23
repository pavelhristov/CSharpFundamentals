using System;

class Pillars
{
   static void Main()
   {
      //input
      int[,] bits = new int[8, 8];
      for (int i = 0; i < 8; i++)
      {
         int j = 0;
         int n = int.Parse(Console.ReadLine());
         string str = Convert.ToString(n, 2).PadLeft(8, '0');
         foreach (var item in str)
         {
            bits[i, j] = item - '0';
            j++;
         }
      }
      //logic
      int counter = -1;
      int pillar = 0;

      for (int k = 0; k <8; k++)
      {
         int leftCounter = 0;
         int rightCounter = 0;
         for (int i = 0; i < 8; i++)
         {
            for (int j = 0; j < 8; j++)
            {
               if (j < k && bits[i, j] == 1)
               {
                  leftCounter++;
               }
               else if (j > k && bits[i, j] == 1)
               {
                  rightCounter++;
               }
            }
         }
         if (leftCounter == rightCounter)
         {
            pillar = 7-k;
            counter = leftCounter;
            break;
         }
      }
      //output
      if (counter != -1)
      {
         Console.WriteLine(pillar);
         Console.WriteLine(counter);
      }
      else
      {
         Console.WriteLine("No");
      }
   }
}