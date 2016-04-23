using System;
using System.Numerics;

class Tribonacci
{
   static void Main()
   {
      //input
      BigInteger tribOne = BigInteger.Parse(Console.ReadLine());
      BigInteger tribTwo = BigInteger.Parse(Console.ReadLine());
      BigInteger tribThree = BigInteger.Parse(Console.ReadLine());
      int N = int.Parse(Console.ReadLine());

      //logic
      

      for (int i = 3; i < N; i++)
      {
         BigInteger tribNext = tribOne+tribTwo+tribThree;
         tribOne = tribTwo;
         tribTwo = tribThree;
         tribThree = tribNext;
      }

      //output
      Console.WriteLine(tribThree);
   }
}