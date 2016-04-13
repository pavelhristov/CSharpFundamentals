using System;

class IntDoubleString
{
   static void Main()
   {
      string text = Console.ReadLine();
      string input = Console.ReadLine();

      switch (text)
      {
         case "integer": Console.WriteLine("{0}", int.Parse(input) + 1); break;
         case "real": Console.WriteLine("{0:F2}", double.Parse(input) + 1); break;
         case "text": Console.WriteLine(input + "*"); break;
         default: 
            break;
      }
   }
}
