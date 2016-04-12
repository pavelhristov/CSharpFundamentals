using System;

class Interval
{
   static void Main()
   {
      int N = int.Parse(Console.ReadLine());
      int M = int.Parse(Console.ReadLine());
      int k = 0;

      for (int i = N+1; i < M; i++)
      {
         if (i%5==0)
         {
            k++;
         }
      }
      Console.WriteLine(k);
   }
}
