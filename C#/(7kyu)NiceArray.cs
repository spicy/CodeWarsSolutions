using System;
using System.Collections.Generic;

//https://www.codewars.com/kata/59b844528bcb7735560000a0
public class Kata
{
  public static bool IsNice(int[] arr)
  {
    if (arr.Length == 0 || arr.Length == 1) return false;

    Dictionary<int, bool> dict = new Dictionary<int, bool>();
    foreach (int value in arr)
    {
        if (!dict.ContainsKey(value))
            dict.Add(value, true);
    }

    // check if there exists a value in the array that doesnt have a +1 or -1 also in the dict
    foreach (int arrayValue in arr)
    {
        if (!dict.ContainsKey(arrayValue - 1) && !dict.ContainsKey(arrayValue + 1))
            return false;
    }
    return true;
  }
}