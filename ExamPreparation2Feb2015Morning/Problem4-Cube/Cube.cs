using System;

class Program
{
   static void Main()
   {
      //input
      int N = int.Parse(Console.ReadLine());

      //logic & output
      int mid = N - 1;
      int fieldSize = N * 2 - 1;
      char empty = ' ';
      char top = '/';
      char side = 'X';
      char edge = ':';

      for (int row = 0; row < fieldSize; row++)
      {
         for (int col = 0; col < fieldSize; col++)
         {
            if ((col == 0 && row >= mid) ||
               (col == mid && row >= mid) ||
               (col == fieldSize - 1 && row <= mid) ||
               (col >= mid && row == 0) ||
               (col <= mid && row == mid) ||
               (col <= mid && row == fieldSize - 1) ||
               (row + col == mid) ||
               (row + col == fieldSize - 1 + mid) ||
               ((row + col == fieldSize - 1) && (row <= mid)))
            {
               Console.Write(edge);
            }
            else if (
               (col + row > mid) && (col + row < fieldSize - 1)&&(row<mid))
            {
               Console.Write(top);
            }
            else if ((col+row>fieldSize-1)&&(col+row<fieldSize-1+mid)&&(col> mid))
            {
               Console.Write(side);
            }
            else
            {
               Console.Write(empty);
            }
         }
         Console.WriteLine();
      }
   }
}