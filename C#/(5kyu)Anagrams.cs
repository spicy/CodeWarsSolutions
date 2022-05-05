using System;
using System.Collections.Generic;

//https://www.codewars.com/kata/523a86aa4230ebb5420001e1
public static class Kata
{
    static string SortString(string input)
    {
        char[] characters = input.ToCharArray(0, input.Length);
        Array.Sort(characters);
        return new string(characters);
    }

    public static List<string> Anagrams(string word, List<string> words)
    {
        string sortedWord = SortString(word);
        List<string> anagrams = new List<string>();

        foreach (string listWord in words)
        {
            string sortedListWord = SortString(listWord);

            if (String.Equals(sortedWord, sortedListWord))
                anagrams.Add(listWord);
        }
        return anagrams;
    }
}