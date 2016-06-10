using System;

class MalkoKote
{
   static void Main()
   {
      //input
      int size = int.Parse(Console.ReadLine());
      char c = Convert.ToChar(Console.ReadLine());
      //logic & output
      char empty = ' ';
      for (int j = 0; j < size; j++)
      {
         for (int i = 0; i < (size - (size % 10) / 2 - 1); i++)
         {
            if (((i == 1 || (i == 2 + (size / 6))) && (j == 0)) ||
               (((j >= 1) && (j <= size / 6)) && ((i >= 1) && (i <= 2 + (size / 6)))) ||
               (((j > size / 6) && (j <= 2 * (size / 6))) && ((i > 1) && (i < 2 + (size / 6)))) ||
               (((j > 2 * (size / 6)) && (j <= size / 4 + 2 * (size / 6))) && ((i >= 1) && (i <= 2 + (size / 6)))) ||
               (((j > size / 4 + 2 * (size / 6)) && (j < size - 1)) && (((i >= 0) && (i <= 3 + (size / 6))) || (i == 6 + (size / 6)))) ||
               ((j == size - 1) && ((i >= 1) && (i <= 5 + (size / 6)))) ||
               ((j == size - 2) && ((i >= 5 + (size / 6)) && (i <= 6 + (size / 6)))) ||
               ((j == size / 4 + 2 * (size / 6)) && ((i >= 6 + (size / 6)) && (i < 5 + (2 * size / 3))))
               )
            {
               Console.Write(c);
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