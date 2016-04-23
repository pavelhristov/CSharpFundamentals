using System;

class SequencesOfBits
{
   static void Main()
   {
      //input
      int N = int.Parse(Console.ReadLine());
      int[] numbers = new int[N];
      string str="";

      for (int i = 0; i < N; i++)
      {
         numbers[i] = int.Parse(Console.ReadLine());
         str = str + Convert.ToString(numbers[i], 2).PadLeft(30, '0');
      }
      //logic
      int zeroCounter=0;
      int maxZeroCounter=0;
      int oneCounter=0;
      int maxOneCounter = 0;

      foreach (var item in str)
      {
         if (item=='0')
         {
            if (zeroCounter == 0)
            {
               maxOneCounter = Math.Max(maxOneCounter, oneCounter);
               oneCounter = 0;
            }
            zeroCounter++;
         }
         else if (item=='1')
         {
            if (oneCounter == 0)
            {
               maxZeroCounter = Math.Max(maxZeroCounter, zeroCounter);
               zeroCounter = 0;
            }
            oneCounter++;
         }
      }

      maxZeroCounter = Math.Max(maxZeroCounter, zeroCounter);
      maxOneCounter = Math.Max(maxOneCounter, oneCounter);
      //output
      Console.WriteLine(maxOneCounter);
      Console.WriteLine(maxZeroCounter);
   }
}