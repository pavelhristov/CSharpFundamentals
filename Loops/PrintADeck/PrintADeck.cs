using System;

class PrintADeck
{
   static void Main()
   {
      string sign = Console.ReadLine();
      int card;

      if (int.TryParse(sign, out card))
      {
         for (int i = 2; i <= card; i++)
         {
            Console.WriteLine("{0} of spades, {0} of clubs, {0} of hearts, {0} of diamonds", i);
         }
      }
      else
      {
         for (int i = 2; i <= 10; i++)
         {
            Console.WriteLine("{0} of spades, {0} of clubs, {0} of hearts, {0} of diamonds", i);
         }
         switch (sign)
         {
            case "J":
               Console.WriteLine("{0} of spades, {0} of clubs, {0} of hearts, {0} of diamonds", sign); break;
            case "Q":
               Console.WriteLine("{0} of spades, {0} of clubs, {0} of hearts, {0} of diamonds", "J");
               Console.WriteLine("{0} of spades, {0} of clubs, {0} of hearts, {0} of diamonds", sign); break;
            case "K":
               Console.WriteLine("{0} of spades, {0} of clubs, {0} of hearts, {0} of diamonds", "J");
               Console.WriteLine("{0} of spades, {0} of clubs, {0} of hearts, {0} of diamonds", "Q");
               Console.WriteLine("{0} of spades, {0} of clubs, {0} of hearts, {0} of diamonds", sign); break;
            case "A":
               Console.WriteLine("{0} of spades, {0} of clubs, {0} of hearts, {0} of diamonds", "J");
               Console.WriteLine("{0} of spades, {0} of clubs, {0} of hearts, {0} of diamonds", "Q");
               Console.WriteLine("{0} of spades, {0} of clubs, {0} of hearts, {0} of diamonds", "K");
               Console.WriteLine("{0} of spades, {0} of clubs, {0} of hearts, {0} of diamonds", sign); break;
            default:
               break;
         }
      }
   }
}