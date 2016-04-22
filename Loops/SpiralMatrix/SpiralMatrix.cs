using System;

class SpiralMatrix
{
   static void Main()
   {
      //input
      int N = int.Parse(Console.ReadLine());

      //logic
      int[,] matrix = new int[N, N];
      int counter = 0;
      int col = 0;
      int row = 0;
      int end = N - 1;
      int start = 0;
      while (start <= end+10)
      {
         if (col > end)
         {
            col = end;
         }
         else if (col < start)
         {
            col = start;
         }
         if (row > end)
         {
            row = end;
         }
         else if (row < start)
         {
            row = start;
         }
         if (counter>=N*N)
         {
            break;
         }

         if (col == start && row == start)
         {
            for (int i = start; i <= end; i++)
            {
               counter++;
               matrix[col, row] = counter;
               col++;
            }
            row++;
         }
         else if (col == end && row == start + 1)
         {
            for (int i = start; i <= end - 1; i++)
            {
               counter++;
               matrix[col, row] = counter;
               row++;
            }
            col--;
         }
         else if (col == end - 1 && row == end)
         {
            for (int i = start; i <= end - 1; i++)
            {
               counter++;
               matrix[col, row] = counter;
               col--;
            }
            row--;
         }
         else if (col == start && row == end - 1)
         {
            for (int i = start; i < end - 1; i++)
            {
               counter++;
               matrix[col, row] = counter;
               row--;
            }
         }
         if (col == row)
         {
            start++;
            end--;
         }     
      }
      //output
      for (int i = 0; i < N; i++)
      {
         for (int j = 0; j < N; j++)
         {
            Console.Write("{0} ", matrix[j, i]);
         }
         Console.WriteLine();
      }
   }
}