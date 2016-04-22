using System;

class TextToNumber
{
   static void Main()
   {
      //input
      int module = int.Parse(Console.ReadLine());
      string text = Console.ReadLine();

      //logic
      long result = 0;

      foreach (var symbol in text)
      {
         if (symbol == '@')
         {
            break;
         }
         else if (('0' <= symbol) && (symbol <= '9'))
         {
            result *= (symbol - '0');
         }
         else if (('a' <= symbol) && (symbol <= 'z'))
         {
            result += (symbol - 'a');
         }
         else if (('A' <= symbol) && (symbol <= 'Z'))
         {
            result += (symbol - 'A');
         }
         else
         {
            result %= module;
         }
      }


      //output
      Console.WriteLine(result);

   }
}