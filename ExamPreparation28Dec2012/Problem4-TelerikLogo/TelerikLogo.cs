using System;

class TelerikLogo
{
   static void Main()
   {
      //input
      int x = int.Parse(Console.ReadLine());
      int y = x;
      int z = x / 2 + 1;

      //logic
      char asteriks = '*';
      char dot = '.';

      int length = 2 * z + 2 * y - 3;
      int height = y + 2 * x - 2;

      for (int i = 0; i < height; i++)
      {
         for (int j = 0; j < length; j++)
         {
            if ((i + j == z - 1) || (j - i == length - z) ||   //printing z
               (((j - i == z - 1) || (i + j == length - z)) && (i < x + y - 1)) ||        //printing y and upper x
               (((i - j == height - x - z + 1) || (j + i == height + z + (x - 3))) && (i >= x + y - 1)))  //printing lower x
            {
               Console.Write(asteriks);
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