public class Kata
{
    public static bool IsValidWalk(string[] walk)
    {
        if (walk.Length != 10) return false;

        // We are going to calculate a trip using simple y and x coordinates
        // n = y++ and s = y--
        // w = x-- and e = x++

        int y = 0;
        int x = 0;

        foreach (string direction in walk)
        {
            if (direction == "n") y++;
            if (direction == "s") y--;
            if (direction == "w") x--;
            if (direction == "e") x++;
        }


        if (y == 0 && x == 0) return true;

        return false;
    }
    public static void Main()
    {
        // ["n","s","n","s","n","s","n","s","n","s"] should return true
        // ["w","e","w","e","w","e","w","e","w","e","w","e"] should return false
        // ["w"] should return false
        // ["n","n","n","s","n","s","n","s","n","s"] should return false

        // Console.WriteLine(IsValidWalk(new string[] { "n", "s", "n", "s", "n", "s", "n", "s", "n", "s" }));
        // Console.WriteLine(IsValidWalk(new string[] { "w", "e", "w", "e", "w", "e", "w", "e", "w", "e", "w", "e" }));
        // Console.WriteLine(IsValidWalk(new string[] { "w" }));
        // Console.WriteLine(IsValidWalk(new string[] { "n", "n", "n", "s", "n", "s", "n", "s", "n", "s" }));
    }
}