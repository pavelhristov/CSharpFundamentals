using System;

class EncodingSum
{
   static void Main()
   {
      //input
      int module = int.Parse(Console.ReadLine());
      string text = Console.ReadLine();

      //logic
      ulong result = 0;

      foreach (var item in text)
      {
         if (item=='@')
         {
            break;
         }
         else if ((item>='0') && (item<='9'))
         {
            result *= (ulong)(item - '0');
         }
         else if ((item>='A') && (item<='Z'))
         {
            result += (ulong)(item - 'A');
         }
         else if ((item>='a') && (item<='z'))
         {
            result += (ulong)(item - 'a');
         }
         else
         {
            result %= (ulong)module;
         }
      }

      //output
      Console.WriteLine(result);

   }
}