public class Kata
{
    public static void Main()
    {
        int[] myArr = new int[] { 1, 2, 0, 1, 0, 1, 0, 3, 0, 1 };

        int[] result1 = MoveZeroes(myArr);
        int[] result2 = MoveZeroesList(myArr);

        Console.WriteLine(string.Join(",", result1));
        Console.WriteLine(string.Join(",", result2));
    }


    // Using an array with fixed size
    // When we create an array with a fixed size, every contiguos memory slot is already holding the value of 0
    // So in this case we can just assign non-zero values from the start of the new array, 
    // which will leave us with 0 at the end.
    public static int[] MoveZeroes(int[] arr)
    {
        int[] result = new int[arr.Length];

        int i = 0; // This indexer will be used to assign non-zero values to the result array and incremented each time.
        int j = 0; // This indexer will be used to iterate the arr values to find non-zero values, its going to be incremented regardless.

        while (j < arr.Length)
        {
            // This is only going to run for non-zero values;
            if (arr[j] != 0)
            {
                result[i] = arr[j];
                i++;
            }

            j++;
        }

        return result;
    }
    // Using List data structure that grows in size dynamically
    // Here are using a List in order to be able to .Add all non-zero elements at the end of the list
    // We are also counting how many zeroes we have encountered so we can .Add them all at once at the end
    public static int[] MoveZeroesList(int[] arr)
    {
        List<int> zeroesAtTheEnd = new List<int>();

        int i = 0;
        int zeroCount = 0;

        // Loop through the non-zero values and add them to the list
        while (i < arr.Length)
        {
            if (arr[i] != 0)
            {
                zeroesAtTheEnd.Add(arr[i]);
            }
            else
            {
                zeroCount++;
            }

            i++;
        }

        // Add the zeroes at the end
        while (zeroCount > 0)
        {
            zeroesAtTheEnd.Add(0);
            zeroCount--;
        }

        // Finally convert the end result of our list to an array of fixed size
        int[] result = zeroesAtTheEnd.ToArray();

        return result;
    }
}