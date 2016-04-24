using System;

class ExcelColumns
{
   static void Main()
   {
      //input
      int N = int.Parse(Console.ReadLine());
      char[] columns = new char[N];
      for (int i = 0; i < N; i++)
      {
         columns[i] = Convert.ToChar(Console.ReadLine());
      }

      //logic 
      ulong result = 0;
      for (int i = 0; i < N; i++)
      {
         if (i > 0)
         {
            result *= 26;
         }
         result += (ulong)columns[i] - 'A' + 1;
      }

      //output

      Console.WriteLine(result);
   }
}