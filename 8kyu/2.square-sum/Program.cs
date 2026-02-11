public static class Kata
{
    public static void Main()
    {
        Console.WriteLine(SquareSum(new int[] { 1, 2, 2 }));
    }
    public static int SquareSum(int[] numbers)
    {
        // Initialize sum as 0
        int sum = 0;

        foreach (int num in numbers)
        {
            // Square a number by multiplying it by itself.
            sum += num * num;
        }

        return sum;
    }
}