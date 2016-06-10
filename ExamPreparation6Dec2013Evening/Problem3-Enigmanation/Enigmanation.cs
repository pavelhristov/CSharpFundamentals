using System;

class Enigmanation
{
   static void Main()
   {
      //input
      string str = Console.ReadLine();

      //logic
      double result = 0;

      string nextstr = "";

      for (int i = 0; i < str.Length; i++)
      {
         string brackets = "";
         if (str[i] == '(')
         {
            for (int j = i + 1; j < str.Length; j++)
            {
               if (str[j] != ')')
               {
                  brackets += str[j];
                  i++;
               }
               else
               {
                  brackets+="=";
                  i+=2;
                  break;
               }
            }
            nextstr += Solve(brackets);
         }
         nextstr += str[i];
      }
      result = Solve(nextstr);
      //output
      Console.WriteLine("{0:F3}", result);
   }
   public static double Solve(string nextstr)
   {
      double result = 0;
      string a = "";
      string b = "";
      char operation = '\0';
      foreach (var item in nextstr)
      {
         switch (item)
         {
            case '+':
               switch (operation)
               {
                  case '*': result = int.Parse(a) * int.Parse(b); operation = item; a = Convert.ToString(int.Parse(a) * int.Parse(b)); b = ""; continue;
                  case '%': result = int.Parse(a) % int.Parse(b); operation = item; a = Convert.ToString(int.Parse(a) % int.Parse(b)); b = ""; continue;
                  case '+': result = int.Parse(a) + int.Parse(b); operation = item; a = Convert.ToString(int.Parse(a) + int.Parse(b)); b = ""; continue;
                  case '-': result = int.Parse(a) - int.Parse(b); operation = item; a = Convert.ToString(int.Parse(a) - int.Parse(b)); b = ""; continue;
                  default:
                     operation = item; a = b; b = "";
                     continue;
               }
            case '-':
               switch (operation)
               {
                  case '*': result = int.Parse(a) * int.Parse(b); operation = item; a = Convert.ToString(int.Parse(a) * int.Parse(b)); b = ""; continue;
                  case '%': result = int.Parse(a) % int.Parse(b); operation = item; a = Convert.ToString(int.Parse(a) % int.Parse(b)); b = ""; continue;
                  case '+': result = int.Parse(a) + int.Parse(b); operation = item; a = Convert.ToString(int.Parse(a) + int.Parse(b)); b = ""; continue;
                  case '-': result = int.Parse(a) - int.Parse(b); operation = item; a = Convert.ToString(int.Parse(a) - int.Parse(b)); b = ""; continue;
                  default:
                     operation = item; a = b; b = "";
                     continue;
               }
            case '*':
               switch (operation)
               {
                  case '*': result = int.Parse(a) * int.Parse(b); operation = item; a = Convert.ToString(int.Parse(a) * int.Parse(b)); b = ""; continue;
                  case '%': result = int.Parse(a) % int.Parse(b); operation = item; a = Convert.ToString(int.Parse(a) % int.Parse(b)); b = ""; continue;
                  case '+': result = int.Parse(a) + int.Parse(b); operation = item; a = Convert.ToString(int.Parse(a) + int.Parse(b)); b = ""; continue;
                  case '-': result = int.Parse(a) - int.Parse(b); operation = item; a = Convert.ToString(int.Parse(a) - int.Parse(b)); b = ""; continue;
                  default:
                     operation = item; a = b; b = "";
                     continue;
               }
            case '%':
               switch (operation)
               {
                  case '*': result = int.Parse(a) * int.Parse(b); operation = item; a = Convert.ToString(int.Parse(a) * int.Parse(b)); b = ""; continue;
                  case '%': result = int.Parse(a) % int.Parse(b); operation = item; a = Convert.ToString(int.Parse(a) % int.Parse(b)); b = ""; continue;
                  case '+': result = int.Parse(a) + int.Parse(b); operation = item; a = Convert.ToString(int.Parse(a) + int.Parse(b)); b = ""; continue;
                  case '-': result = int.Parse(a) - int.Parse(b); operation = item; a = Convert.ToString(int.Parse(a) - int.Parse(b)); b = ""; continue;
                  default:
                     operation = item; a = b; b = "";
                     continue;
               }
            case '=':
               switch (operation)
               {
                  case '*': result = int.Parse(a) * int.Parse(b); operation = item; a = Convert.ToString(int.Parse(a) * int.Parse(b)); b = ""; break;
                  case '%': result = int.Parse(a) % int.Parse(b); operation = item; a = Convert.ToString(int.Parse(a) % int.Parse(b)); b = ""; break;
                  case '+': result = int.Parse(a) + int.Parse(b); operation = item; a = Convert.ToString(int.Parse(a) + int.Parse(b)); b = ""; break;
                  case '-': result = int.Parse(a) - int.Parse(b); operation = item; a = Convert.ToString(int.Parse(a) - int.Parse(b)); b = ""; break;
                  default: break;
               }
               break;
            default:
               b += item;
               continue;
         }
      }
      return result;
   }
}