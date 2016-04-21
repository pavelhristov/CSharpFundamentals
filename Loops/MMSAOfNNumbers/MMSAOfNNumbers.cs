using System;

class MMSAOfNNumbers
{
   static void Main()
   {
      int N = int.Parse(Console.ReadLine());
      double[] array = new double[N];

      double min = int.MaxValue;
      double max = int.MinValue;
      double sum = 0;

      for (int i = 0; i < N; i++)
      {
         array[i] = double.Parse(Console.ReadLine());
      }

      foreach (var item in array)
      {
         sum += item;
         if (min > item)
         {
            min = item;
         }
         if (max < item)
         {
            max = item;
         }
      }
      double avg = sum / N;

      Console.WriteLine("min={0:F2}", min);
      Console.WriteLine("max={0:F2}", max);
      Console.WriteLine("sum={0:F2}", sum);
      Console.WriteLine("avg={0:F2}", avg);

   }
}
