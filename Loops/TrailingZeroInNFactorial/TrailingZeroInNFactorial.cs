using System;

class TrailingZeroInNFactorial
{
   static void Main()
   {
      //input
      int N = int.Parse(Console.ReadLine());

      //logic
      int counter = 0;

      if (N == 5)
      {
         counter = 1;
      }
      else
      {
         for (int i = 5; N / i >= 1; i *= 5)
         {
            counter += N / i;
         }
      }
      //output
      Console.WriteLine(counter);
   }
}