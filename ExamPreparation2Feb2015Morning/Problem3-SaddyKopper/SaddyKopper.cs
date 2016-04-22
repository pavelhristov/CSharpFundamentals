using System;
using System.Numerics;

class SaddyKopper
{
   static void Main()
   {
      //input
      string strNum = Console.ReadLine();

      //logic
      int counter = 0;

      while ((strNum.Length > 1) && (counter < 10))
      {
         BigInteger product = 1;
         while (strNum.Length > 0)
         {
            strNum = strNum.Substring(0, strNum.Length - 1);
            int sum = 0;

            for (int i = 0; i < strNum.Length; i += 2)
            {
               sum += (strNum[i] - '0');
            }
            product *= sum != 0 ? sum : 1;
         }
         counter++;
         strNum = product.ToString();
      }


      //output
      if (counter < 10)
      {
         Console.WriteLine(counter);
      }
      Console.WriteLine(strNum);
   }
}