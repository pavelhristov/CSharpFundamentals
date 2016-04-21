using System;

class NumbersFromOneToN
{
   static void Main()
   {
      int N = int.Parse(Console.ReadLine());

      for (int i = 1; i <= N; i++)
      {
         if (i == N)
         {
            Console.WriteLine(i);
         }
         else
         {
            Console.Write("{0} ", i);
         }

      }
   }
}
