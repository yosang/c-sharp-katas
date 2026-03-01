
using System.Text;

public class Kata
{
    public static string breakCamelCase(string str)
    {
        if (str.Length < 1) return "";

        StringBuilder sb = new();

        foreach (char c in str)
        {
            if (!Char.IsUpper(c)) // Check if a character is upper string
            {
                sb.Append(c);
            }
            else
            {
                sb.Append(" " + c);
            }
        }

        return sb.ToString();
    }
    public static void Main()
    {
        Console.WriteLine(breakCamelCase("camelCase"));
        Console.WriteLine(breakCamelCase("identifier"));
        Console.WriteLine(breakCamelCase(""));
    }
}