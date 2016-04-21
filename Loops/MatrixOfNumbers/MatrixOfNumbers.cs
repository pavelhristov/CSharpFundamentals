using System;

class MatrixOfNumbers
{
   static void Main()
   {
      //input
      int N = int.Parse(Console.ReadLine());

      //logic & output
      int k = 1;
      int count = 1;

      for (int i = 1; i <= N; i++)
      {
         if (i < N)
         {
            Console.Write("{0} ", k);
         }
         else if (i==N)
         {
            Console.WriteLine("{0} ", k);
            i = 0;
            k = count;
            count++;
            
            if (count>N)
            {
               break;
            }
         }
         k++;
      }
      


   }
}