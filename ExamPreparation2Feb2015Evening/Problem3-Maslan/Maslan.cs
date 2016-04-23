using System;
using System.Numerics;

class Maslan
{
   static void Main()
   {
      //input
      BigInteger num = long.Parse(Console.ReadLine());

      //logic
      
      int counter = 0;

      while (counter < 10 && num>0)
      {
         BigInteger result = 1;
         counter++;
         while (num>1)
         {
            int sum=0;
            num = num / 10;
            string strNum = (num).ToString();
            for (int i = 1; i < strNum.Length; i+=2)
            {
               sum += (strNum[i] - '0');
            }
            if (sum==0)
            {
               result *= 1;
            }
            else
            {
               result *= sum;
            }
         }
         num = result;
         if (num<10)
         {
            break;
         }
      }

      //output
      if (counter<10)
      {
         Console.WriteLine(counter);
      }
      Console.WriteLine(num);
   }
}