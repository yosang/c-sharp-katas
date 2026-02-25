public class Kata
{
    // An octet is simply a value that consists of exactly 8 bits
    // In c# this value has a type and that is byte
    // To check if a number is an octet, we need to verify its ranges for a byte, which is 0 - 255

    public static bool isAnOctet(int n)
    {
        if (n < 0 || n > 255 || n != (byte)n) return false; // If the num is below 0, or above 255, or not of a byte type, return false

        return true;
    }

    public static bool IsValidIp(string ipAddres)
    {
        string[] arrOfOctets = ipAddres.Split(".");

        if (arrOfOctets.Length != 4) return false;

        foreach (string octet in arrOfOctets)
        {
            if (octet != "0" && octet.StartsWith("0") || octet.StartsWith(" ") || octet.EndsWith(" "))
                return false;

            if (int.TryParse(octet, out int number))
            {
                if (!isAnOctet(number))
                    return false;
            }
            else
            {
                return false;
            }
        }

        return true;
    }
    public static void Main()
    {
        // Truthful scenarios
        // Console.WriteLine(IsValidIp("1.2.3.4"));
        // Console.WriteLine(IsValidIp("123.45.67.89"));

        // Erroneous scenarios
        // Console.WriteLine(IsValidIp("abc"));
        // Console.WriteLine(IsValidIp("abc.def.ghi.jkl"));
        // Console.WriteLine(IsValidIp("123.456.789.0"));
        Console.WriteLine(IsValidIp("12.34.56 .1"));
        // Console.WriteLine(IsValidIp("0.0.0.0"));
        // Console.WriteLine(IsValidIp("1.2.3"));
        // Console.WriteLine(IsValidIp("1.2.3.4.5"));
        // Console.WriteLine(IsValidIp("123.456.78.90"));
        // Console.WriteLine(IsValidIp("123.045.067.089"));

        // * Testing the octet function
        // Console.WriteLine(isAnOctet(05)); // True
        // Console.WriteLine(isAnOctet(5)); // True
        // // Console.WriteLine(isAnOctet(300)); // False
        // Console.WriteLine(isAnOctet(-1)); // False
    }
}