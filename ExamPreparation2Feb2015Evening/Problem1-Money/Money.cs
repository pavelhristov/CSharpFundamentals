using System;

class Money
{
   static void Main()
   {
      //input 
      int numStudents = int.Parse(Console.ReadLine());
      int sheets = int.Parse(Console.ReadLine());
      double price = double.Parse(Console.ReadLine());

      //logic
      int realm = 400;
      double result=0;

      result = ((double)numStudents * sheets / realm) * price;

      //output
      Console.WriteLine("{0:F3}",result);

   }
}