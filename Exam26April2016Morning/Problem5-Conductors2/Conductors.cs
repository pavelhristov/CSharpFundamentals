using System;

class Conductors
{
   static void Main()
   {
      //input
      int p = int.Parse(Console.ReadLine());
      int m = int.Parse(Console.ReadLine());
      int[] tickets = new int[Math.Abs(m)];
      for (int i = 0; i < m; i++)
      {
         tickets[i] = int.Parse(Console.ReadLine());
      }
      //logic
      string check = Convert.ToString(p, 2);
      foreach (var item in tickets)
      {
         int mask = item;
         string newNum = "";
         for (int i = 0; i < Convert.ToString(item, 2).Length; i++)
         {
            if ((mask & p) == p)
            {
               mask = mask >> check.Length;
               for (int j = 0; j < check.Length; j++)
               {
                  newNum += "0";
               }
               if (i+check.Length-1> Convert.ToString(item, 2).Length)
               {
                  break;
               }
               else
               {
               i += check.Length - 1;
               }
            }
            else
            {
               newNum += (mask & 1);
               mask = mask >> 1;
            }
         }
         int result = 0;
         int newTicket = int.Parse(ReverseString(newNum));
         for (int i = 0; i < newNum.ToString().Length; i++)
         {
            result += (newTicket % 10) * (int)Math.Pow(2, i);
            newTicket = newTicket / 10;
         }
         //output
         Console.WriteLine(result);
      }
   }
   public static string ReverseString(string s)
   {
      char[] arr = s.ToCharArray();
      Array.Reverse(arr);
      return new string(arr);
   }
}