using System;

class BiggestOfFive
{
   static void Main()
   {
      int n = 5;

      double[] numbers = new double[n];

      for (int i = 0; i < n; i++)
      {
         numbers[i] = double.Parse(Console.ReadLine());
      }

      double max = numbers[0];

      for (int i = 1; i < n; i++)
      {
         if (numbers[i] > max)
         {
            max = numbers[i];
         }
      }
      Console.WriteLine(max);
   }
}