using System;
using System.Text;

// https://www.codewars.com/kata/559536379512a64472000053
public class PlayPass
{
    // needs to be lowercase input
    private static char CircularShift(char c, int n)
    {
        int offset = 26;
        if (n > 0) offset *= -1;

        if ((int)c + n > 122 || (int)c + n < 97)
            return (char)((int)c + n + offset);

        return (char)((int)c + n);
    }

    private static bool IsDigit(char c)
    {
        return ((int)c >= 48) && ((int)c <= 57);
    }

    private static bool IsLetter(char c)
    {
        char temp = Char.ToLower(c);
        return ((int)temp >= 97) && ((int)temp <= 122);
    }

    public static string playPass(string s, int n)
    {
        StringBuilder result = new StringBuilder();

        for (int i = s.Length - 1; i >= 0; i--)
        {
            if (IsDigit(s[i]))
            {
                result.Append(9 - (int)Char.GetNumericValue(s[i]));
            }
            else if (IsLetter(s[i]))
            {
                char temp = Char.ToLower(s[i]);
                temp = CircularShift(temp, n);

                if (i % 2 == 0) temp = Char.ToUpper(temp);
                else temp = Char.ToLower(temp);

                result.Append(temp);
            }
            else result.Append(s[i]);
        }
        return result.ToString();
    }
}