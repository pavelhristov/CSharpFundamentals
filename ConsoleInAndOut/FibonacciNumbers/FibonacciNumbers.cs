using System;

class FibonacciNumbers
{
   static void Main()
   {
      string fibonacci = "0";
      int N = int.Parse(Console.ReadLine());
      ulong[] fib = new ulong[N];
      fib[0] = 0;

      for (int i = 1; i < N; i++)
      {
         if (i <=1)
         {
            fib[i] = 1;
         }
         else
         {
            fib[i] = fib[i - 2] + fib[i - 1];
         }
         fibonacci += ", " + fib[i];       
      }
      Console.WriteLine(fibonacci);
   }
}
