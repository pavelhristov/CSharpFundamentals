using System;

class KaspichaniaBoats
{
   static void Main()
   {
      //input
      int n = int.Parse(Console.ReadLine());

      //logic
      int width = n * 2 + 1;
      int height = 6 + ((n - 3) / 2) * 3;
      int boatHeight = 2 * height / 3;
      int boatBase = height / 3;
      char dot = '.';
      char asterisk = '*';

      for (int i = 0; i < height; i++)
      {
         for (int j = 0; j < width; j++)
         {
            if ((i + j == n) || (j - i == n) ||
               (i == n) || (j == n) || (((j > (width - n) / 2) && (j < n + (width - n) / 2)) && (i == height - 1)) ||
               (i + j == height + n + n / 2 - 1) || (i - j == n))
            {
               Console.Write(asterisk);
            }
            else
            {
               Console.Write(dot);
            }
         }
         Console.WriteLine();
      }
   }
}