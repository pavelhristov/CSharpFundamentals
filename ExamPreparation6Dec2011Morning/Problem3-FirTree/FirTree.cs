using System;

class FirTree
{
   static void Main()
   {
      //input
      int N = int.Parse(Console.ReadLine());

      //logic & output
      char asterisk = '*';
      char point = '.';
      int cols = (N - 1) * 2 - 1;

      for (int i = 1; i <= N; i++)
      {
         for (int j = 0; j < cols; j++)
         {
            if (i==N)
            {
               if ((j > ((cols / 2) - 1)) && (j < (cols - ((cols / 2)))))
               {
                  Console.Write(asterisk);
               }
               else
               {
                  Console.Write(point);
               }
            }
            else if ((j>((cols/2)-i))&&(j<(cols - ((cols / 2)-i+1))))
            {
               Console.Write(asterisk);
            }
            else
            {
               Console.Write(point);
            }
         }
         Console.WriteLine();
      }
   }
}