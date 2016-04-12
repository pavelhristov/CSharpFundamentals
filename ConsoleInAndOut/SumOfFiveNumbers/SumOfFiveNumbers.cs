using System;

class SumOfFiveNumbers
{
   static void Main()
   {
      int n = 5;
      int[] x = new int[n];
      int sum = 0;

      for (int i = 0; i < x.Length; i++)
      {
         x[i] = int.Parse(Console.ReadLine());
         sum += x[i];
      }

      Console.WriteLine(sum);
   }
}
