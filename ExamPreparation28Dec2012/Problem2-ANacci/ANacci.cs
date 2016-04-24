using System;

class ANacci
{
   static void Main()
   {
      //input 
      char first = Convert.ToChar(Console.ReadLine());
      char second = Convert.ToChar(Console.ReadLine());
      int L = int.Parse(Console.ReadLine());

      //logic & output
      char empty = ' ';
      char next = first;
      int s = first - 'A' + 1;

      for (int i = 1; i <= L; i++)
      {
         for (int j = 0; j < i; j++)
         {
            if ((j > 0) && (j < i - 1))
            {
               Console.Write(empty);
            }
            else if (j == 0)
            {
               Console.Write(next);
               s = first - 'A' + 1;
               first = second;
               second = Convert.ToChar(first + s);
               if ((int)second > 'Z')
               {
                  second -= Convert.ToChar(26);
               }
               next = first;

            }
            else if (j == i - 1)
            {
               Console.Write(next);
               s = first - 'A' + 1;
               first = second;
               second = Convert.ToChar(first + s);
               if ((int)second > 'Z')
               {
                  second -= Convert.ToChar(26);
               }
               next = first;

            }
         }
         Console.WriteLine();
      }
   }
}