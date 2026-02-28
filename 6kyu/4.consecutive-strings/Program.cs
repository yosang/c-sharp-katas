using System.Text;

public class Kata
{
    public static string longest_consec(string[] arr)
    {
        List<string> result = new();

        int i = 0;
        while (i < arr.Length - 1)
        {
            StringBuilder sb = new();
            sb.Append(string.Concat(arr[i], arr[i + 1]));
            result.Add(sb.ToString());
            i++;
        }

        List<string> sorted = result.OrderByDescending(x => x.Length).ToList();

        return sorted[0];
    }

    public static void Main()
    {
        // string[] test1 = new string[] { "tree", "foling", "trashy", "blue", "abcdef", "uvwxyz" }; 
        string[] test1 = new string[] { "zone", "abigail", "theta", "form", "libe", "zas", "theta", "abigail" };

        Console.WriteLine(longest_consec(test1));
    }
}