using System;

class Conductors
{
   static void Main()
   {
      //input
      int p = int.Parse(Console.ReadLine());
      int m = int.Parse(Console.ReadLine());
      int[] tickets = new int[m];
      for (int i = 0; i < m; i++)
      {
         tickets[i] = int.Parse(Console.ReadLine());
      }
      //logic
      string check = ReverseString(Convert.ToString(p, 2));
      foreach (var item in tickets)
      {
         int result = 0;
         string newNum;
         newNum = ReverseString(Convert.ToString(item, 2).PadLeft(Math.Max(tickets.ToString().Length-check.Length,0),'0')).Replace(check, "0".PadLeft(check.Length, '0'));
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