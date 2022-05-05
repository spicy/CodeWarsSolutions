using System;
using System.Text;
using System.Globalization;

//https://www.codewars.com/kata/517abf86da9663f1d2000003
public class Kata
{
  public static string ToCamelCase(string str)
  {
    StringBuilder sb = new StringBuilder();
    
    bool flag = false;
    foreach (char c in str)
    {
      if (c == '-' || c == '_')
      {
        flag = true;
        continue;
      }
      else if (flag)
      {
        sb.Append(Char.ToUpper(c));
        flag = false;
      }
      else sb.Append(c);
    }
    
    return sb.ToString();
  }
}