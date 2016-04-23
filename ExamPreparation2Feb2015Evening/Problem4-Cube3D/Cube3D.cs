using System;

class Cube3D
{
   static void Main()
   {
      //input
      int N = int.Parse(Console.ReadLine());

      //logic & output
      char empty = ' ';
      char edge = ':';
      char side = '|';
      char bot = '-';
      int length = 2 * N - 1;
      int mid = N;

      for (int i = 0; i < length; i++)
      {
         for (int j = 0; j < length; j++)
         {
            if (((j < mid) && (i == 0)) ||
               ((j < mid) && (i == mid - 1)) ||
               ((j == 0) && (i < mid)) ||
               ((j == mid - 1) && (i < mid)) ||
               ((j == i) && (i >= mid)) ||
               ((j == i - mid + 1) && (i >= mid)) ||
               ((j - mid + 1 == i) && (i < mid)) ||
               ((j == length - 1) && (i >= mid)) ||
               ((j >= mid) && (i == length - 1)))
            {
               Console.Write(edge);
            }
            else if ((i >= mid) && (j > i - mid) && (i > j))
            {
               Console.Write(bot);
            }
            else if ((j >= mid) && (i > j - mid) && (j > i))
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