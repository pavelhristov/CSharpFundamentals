using System;

class Printing
{
   static void Main()
   {
      //input
      int numStudents = int.Parse(Console.ReadLine());
      int sheetsPerStudents = int.Parse(Console.ReadLine());
      double price = double.Parse(Console.ReadLine());
      int realm = 500;

      //solution
      double result;
      result = (((double)numStudents * sheetsPerStudents) / realm) * price;


      //output
      Console.WriteLine("{0:F2}",result);
   }
}