using System;

class ShipDamage
{
   static void Main()
   {
      //input
      int sx1 = int.Parse(Console.ReadLine());
      int sy1 = int.Parse(Console.ReadLine());
      int sx2 = int.Parse(Console.ReadLine());
      int sy2 = int.Parse(Console.ReadLine());
      int H = int.Parse(Console.ReadLine());
      int cx1 = int.Parse(Console.ReadLine());
      int cy1 = int.Parse(Console.ReadLine());
      int cx2 = int.Parse(Console.ReadLine());
      int cy2 = int.Parse(Console.ReadLine());
      int cx3 = int.Parse(Console.ReadLine());
      int cy3 = int.Parse(Console.ReadLine());

      //logic
      int dmg = 0;

      if ((((H - cy1 > Math.Min(sy1 - H, sy2 - H)) && (H - cy1 < Math.Max(sy1 - H, sy2 - H)))   //c1 will hit the ship
         && (cx1 > Math.Min(sx1, sx2) && cx1 < Math.Max(sx1, sx2))))
      {
         dmg += 100;
      }
      else if (((H-cy1 == sy1-H)||(H-cy1==sy2-H))&&(cx1>Math.Min(sx1,sx2) && cx1<Math.Max(sx1,sx2)) || //c1 will hit top or bottom of the ship
         (((cx1==sx1 || cx1 ==sx2)&&((H - cy1 >Math.Min( sy1 - H, sy2 - H)) && (H - cy1 < Math.Max(sy1 - H, sy2 - H)))))) //c1>left or right
      {
         dmg += 50;
      }
      else if (((H-cy1 == sy1-H)|| (H - cy1 == sy2 - H))&&(cx1 == sx1 || cx1 == sx2))  //c1 will hit a corner
      {
         dmg += 25;
      }
      if ((((H - cy2 > Math.Min(sy1 - H, sy2 - H)) && (H - cy2 < Math.Max(sy1 - H, sy2 - H)))  //c2 will hit the ship
         && (cx2 > Math.Min(sx1, sx2) && cx2 < Math.Max(sx1, sx2))))
      {
         dmg += 100;
      }
      else if (((H - cy2 == sy1 - H) || (H - cy2 == sy2 - H)) && (cx2 > Math.Min(sx1, sx2) && cx2 < Math.Max(sx1, sx2)) || //c2 will hit top or bottom of the ship
         (((cx2 == sx1 || cx2 == sx2) && ((H - cy2 > Math.Min(sy1 - H, sy2 - H))) && (H - cy2 < Math.Max(sy1 - H, sy2 - H))))) //c2>left or right
      {
         dmg += 50;
      }
      else if (((H - cy2 == sy1 - H) || (H - cy2 == sy2 - H)) && (cx2 == sx1 || cx2 == sx2))  //c2 will hit a corner
      {
         dmg += 25;
      }
      if ((((H - cy3 > Math.Min(sy1 - H, sy2 - H)) && (H - cy3 < Math.Max(sy1 - H, sy2 - H)))  //c3 will hit the ship
         && (cx3 > Math.Min(sx1, sx2) && cx3 < Math.Max(sx1, sx2))))
      {
         dmg += 100;
      }
      else if (((H - cy3 == sy1 - H) || (H - cy3 == sy2 - H)) && (cx3 > Math.Min(sx1, sx2) && cx3 < Math.Max(sx1, sx2)) || //c3 will hit top or bottom of the ship
         (((cx3 == sx1 || cx3 == sx2) && ((H - cy3 > Math.Min(sy1 - H, sy2 - H))) && (H - cy3 < Math.Max(sy1 - H, sy2 - H))))) //c3>left or right
      {
         dmg += 50;
      }
      else if (((H - cy3 == sy1 - H) || (H - cy3 == sy2 - H)) && (cx3 == sx1 || cx3 == sx2))  //c3 will hit a corner
      {
         dmg += 25;
      }


      //output
      Console.WriteLine("{0}%",dmg);
   }
}