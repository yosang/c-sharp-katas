public class Kata
{
    public static void Main()
    {
        Console.WriteLine(Remove("Hi!"));
        Console.WriteLine(Remove("Hi!!!"));
        Console.WriteLine(Remove("!Hi"));
        Console.WriteLine(Remove("!Hi!"));
        Console.WriteLine(Remove("Hi! Hi!"));
        Console.WriteLine(Remove("Hi"));
    }
    public static string Remove(string s)
    {
        string parsed = $"{s.Replace("!", "")}!"; // interpolation
        // string parsed = s.Replace("!", "") + "!"; // concatenation

        return parsed;
    }
}