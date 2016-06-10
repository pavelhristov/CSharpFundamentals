using System;

class SumOfEvenDivisors
{
   static void Main()
   {
      //input
      int a = int.Parse(Console.ReadLine());
      int b = int.Parse(Console.ReadLine());

      //logic
      int sum = 0;
      int num = 0;
      for (int i = 0; i <= Math.Abs(b-a); i++)
      {
         num = Math.Min(a, b) + i;
         for (int j = 2; j <= Math.Max(a,b); j++)
         {
            if ((num%j==0) &&(j%2==0))
            {
               sum += j;
            }
         }
      }
      //output
      Console.WriteLine(sum);
   }
}