using System;

class HexToDecimal
{
   static void Main()
   {
      //input 
      string strHex =  Console.ReadLine();

      //logic
      long result = 0;
      int counter = strHex.Length;

      foreach (var item in strHex)
      {
         counter--;
         switch (item)
         {
            case 'A': result += 10 * (long)Math.Pow(16, counter); continue;
            case 'B': result += 11 * (long)Math.Pow(16, counter); continue;
            case 'C': result += 12 * (long)Math.Pow(16, counter); continue;
            case 'D': result += 13 * (long)Math.Pow(16, counter); continue;
            case 'E': result += 14 * (long)Math.Pow(16, counter); continue;
            case 'F': result += 15 * (long)Math.Pow(16, counter); continue;
            default:
               result += (int)(item-'0') * (long)Math.Pow(16, counter);
               continue;
         }
         
      }

      //output

      Console.WriteLine(result);
   }
}