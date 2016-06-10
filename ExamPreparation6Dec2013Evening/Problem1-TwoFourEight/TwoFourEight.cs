using System;
using System.Numerics;

class TwoFourEight
{
   static void Main()
   {
      //input
      int a = int.Parse(Console.ReadLine());
      int b = int.Parse(Console.ReadLine());
      int c = int.Parse(Console.ReadLine());

      //logic
      BigInteger r = 0;

      switch (b)
      {
         case 2: r = a % c; break;
         case 4: r = a + c; break;
         case 8: r = (BigInteger)a * c; break;
         default:
            break;
      }

      //output
      if (r % 4 == 0)
      {
         Console.WriteLine(r / 4);
      }
      else
      {
         Console.WriteLine(r % 4);
      }
      Console.WriteLine(r);
   }
}