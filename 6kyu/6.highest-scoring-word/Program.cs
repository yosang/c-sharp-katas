using System;

public class Kata
{
    public static int GetPosition(char c)
    {
        char toUpper = Char.ToUpper(c);

        if (toUpper >= 'A' && toUpper <= 'Z') // If the char is between A and Z then we return its position
        {
            return toUpper - 'A' + 1; // If the char is A, 0 + 1 will be 1, otherwise return char - A + 1, which gives us the correct position (1 indexed)
        }

        return -1; // otherwise just return -1
    }
    public static string High(string s)
    {
        string[] strArr = s.Split(" ");

        int highestScore = 0;
        string highestScoreWord = "";

        foreach (string word in strArr)
        {
            int acc = 0;

            foreach (char c in word) acc += GetPosition(c);

            if (highestScore < acc)
            {
                highestScore = acc;
                highestScoreWord = word;
            }
        }

        return highestScoreWord;
    }
    public static void Main()
    {
        Console.WriteLine(High("man i need a taxi up to ubud"));
        Console.WriteLine(High("what time are we climbing up to the volcano"));
        Console.WriteLine(High("take me to semynak"));
        Console.WriteLine(High("aa b"));
        Console.WriteLine(High("b aa"));
        Console.WriteLine(High("bb d"));
        Console.WriteLine(High("d bb"));
        Console.WriteLine(High("aaa b"));
    }
}