using System;

class Calculate
{
   static void Main()
   {
      int N = int.Parse(Console.ReadLine());
      double x = double.Parse(Console.ReadLine());
      double sum = 1;
      double facturiel = 1;

      for (int i = 1 ; i <= N; i++ )
      {
         facturiel *= i;
         sum += facturiel / Math.Pow(x, i);
      }

      Console.WriteLine("{0:F5}", sum);
   }
}