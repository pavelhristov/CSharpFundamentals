using System;

class SumOfNNumbers
{
   static void Main()
   {
      int n = int.Parse(Console.ReadLine());
      double[] x = new double[n];
      double sum = 0;

      for (int i = 0; i < x.Length; i++)
      {
         x[i] = double.Parse(Console.ReadLine());
         sum += x[i];
      }

      Console.WriteLine(sum);
   }
}