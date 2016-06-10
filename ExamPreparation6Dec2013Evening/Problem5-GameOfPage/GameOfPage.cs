using System;

class GameOfPage
{
   static void Main()
   {
      //input
      char[,] tray = new char[16, 16];
      for (int j = 0; j < 16; j++)
      {
         for (int i = 0; i < 16; i++)
         {
            if (i == 15)
            {
               tray[i, j] = Convert.ToChar(Console.ReadLine());
            }
            else
            {
               tray[i, j] = Convert.ToChar(Console.Read());
            }
         }
      }
      //logic
      for (int j = 0; j < 16; j++)
      {
         for (int i = 0; i < 16; i++)
         {
            if (tray[i, j]=='1')
            {

            }
         }
      }

      //output
      Console.WriteLine();

   }
}