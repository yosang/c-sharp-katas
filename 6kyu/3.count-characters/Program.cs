using System.Collections.Generic;
using System;

public class Kata
{
    public static void PrintADictionary(Dictionary<char, int> dict)
    {
        // Debugging: Loop the dictionary to see the output
        foreach (KeyValuePair<char, int> item in dict)
        {
            Console.WriteLine($"\"{item.Key}\":\"{item.Value}\"");
        }
    }
    public static Dictionary<char, int> Count(string str)
    {
        Dictionary<char, int> myDict = new();

        foreach (char c in str)
        {
            if (!myDict.ContainsKey(c))
            {
                myDict[c] = 1;
            }
            else
            {
                myDict[c]++;
            }
        }

        return myDict;
    }
    public static void Main()
    {
        // PrintADictionary(Count("abc"));
        // PrintADictionary(Count("abcc"));
        PrintADictionary(Count("abbcc"));
    }
}