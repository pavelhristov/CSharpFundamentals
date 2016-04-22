using System;
using System.Linq;

class GCD
{
   static void Main()
   {
      //input 
      string strNumbers = Console.ReadLine();
      int[] num = strNumbers.Split(' ').Select(int.Parse).ToArray();

      //logic
      if (num[0]<num[1])
      {
         int K = num[1];
         num[1] = num[0];
         num[0] = K;
      }
      int C = 0;

      while ((num[0] != 0) && (num[1] != 0))
      {
         C = num[0] % num[1];
         if (C != 0)
         {
            num[0] = num[1];
            num[1] = C;
         }
         else
         {
            break;
         }
      }
      //output
      Console.WriteLine(num[1]);
   }
}