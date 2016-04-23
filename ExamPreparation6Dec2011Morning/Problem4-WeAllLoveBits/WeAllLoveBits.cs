using System;
using System.Linq;

class WeAllLoveBits
{
   static void Main()
   {
      //intput
      int N = int.Parse(Console.ReadLine());
      int[] nums = new int[N];

      for (int i = 0; i < N; i++)
      {
         nums[i] = int.Parse(Console.ReadLine());
      }

      //logic
      int[] result = new int[N];

      for (int i = 0; i < N; i++)
      {
         int p1 = ~nums[i];
         int p2 = Convert.ToInt32(new String(Convert.ToString(nums[i], 2).Reverse().ToArray()), 2);
         nums[i] = (nums[i] ^ p1) & p2;
      }
      //output
      foreach (var item in nums)
      {
         Console.WriteLine(item);
      }
   }
}