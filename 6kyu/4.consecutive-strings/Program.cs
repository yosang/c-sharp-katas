using System.Text;

public class Kata
{
    public static string LongestConsec(string[] strarr, int k)
    {
        // We want to form groups of exactly k consecutive strings
        if (strarr == null || strarr.Length == 0 || k <= 0 || k > strarr.Length)
            return "";
        string longest = "";

        for (int i = 0; i <= strarr.Length - k; i++)
        {
            string consec = "";
            for (var j = 0; j < k; j++)
                consec += strarr[i + j];
            if (consec.Length > longest.Length)
                longest = consec;
        }

        return longest;
    }
    public static void Main()
    {
        string[] test1 = new string[] { "tree", "foling", "trashy", "blue", "abcdef", "uvwxyz" };
        // string[] test1 = new string[] { "zone", "abigail", "theta", "form", "libe", "zas", "theta", "abigail" };

        Console.WriteLine(LongestConsec(test1, 2));
    }
}