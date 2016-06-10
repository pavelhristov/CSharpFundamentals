using System;

class NightmareOnCodeStreet
{
   static void Main()
   {
      //input
      string digits = Console.ReadLine();

      //logic
      long sum = 0;
      int counter = 0;
      for (int i = 1; i < digits.Length; i +=2)
      {
         if ('0' <= digits[i] && digits[i] <= '9')
         {
            sum += digits[i] - '0';
            counter++;
         }
      }
      //output
      Console.WriteLine("{0} {1}", counter, sum);
   }
}