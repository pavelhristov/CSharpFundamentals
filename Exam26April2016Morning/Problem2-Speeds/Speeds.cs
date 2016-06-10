using System;

class Speeds
{
   static void Main()
   {
      //input
      int cars = int.Parse(Console.ReadLine());
      int[] speed = new int[cars];
      for (int i = 0; i < cars; i++)
      {
         speed[i] = int.Parse(Console.ReadLine());
      }
      //logic
      int maxSumSpeed = 0;
      int currentSumSpeed = speed[0];
      int currentCounter = 0;
      int maxCounter = 0;
      int speedy = speed[0];
      for (int i = 1; i < speed.Length; i++)
      {
         if (speed[i]>speedy)
         {
            currentCounter++;
            currentSumSpeed += speed[i];
            if (maxCounter<currentCounter)
            {
               maxCounter = currentCounter;
               maxSumSpeed = 0;
            }
         }
         else
         {
            if (currentCounter==maxCounter)
            {
            maxSumSpeed=Math.Max(currentSumSpeed, maxSumSpeed);
            }
            currentSumSpeed = speed[i];
            speedy = speed[i];
            currentCounter = 1;
         }
      }
      maxSumSpeed = Math.Max(currentSumSpeed, maxSumSpeed);
      //output
      Console.WriteLine(maxSumSpeed);
   }
}