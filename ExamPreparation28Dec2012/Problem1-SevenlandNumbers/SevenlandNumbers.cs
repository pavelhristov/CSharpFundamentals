using System;

class SevenlandNumbers
{
   static void Main()
   {
      //input
      int k = int.Parse(Console.ReadLine());

      //logic
      int n = k + 1;
      int nextK = 0;
      int counter = 1;
      do
      {
         int m = n % 10;
         if (m > 6)
         {
            n /= 10;
            n += 1;
         }
         else
         {
            nextK += m * counter;
            n /= 10;
         }
         counter *= 10;
      }
      while (n > 0);
      
      //output
      Console.WriteLine(nextK);
   }
}