using System;
class ModifyBit
{
   static void Main()
   {
      ulong N = uint.Parse(Console.ReadLine());
      byte P = byte.Parse(Console.ReadLine());
      byte v = byte.Parse(Console.ReadLine());

      ulong mask =(ulong) 1 << P;
      ulong result;

      if (v == 0)
      {
         result = N & (~mask);
      }
      else
      {
         result = N | mask;
      }

      Console.WriteLine(result);
   }
}