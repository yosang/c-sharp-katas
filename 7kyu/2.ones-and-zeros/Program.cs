namespace Solution
{
    class Kata
    {
        public static void Main()
        {
            Console.WriteLine(binaryArrayToNumber(new int[] { 1, 0, 0, 1 })); // 9
            // Console.WriteLine(binaryArrayToNumber(new int[] { 1, 1, 1, 1 })); // 15
            // Console.WriteLine(binaryArrayToNumber(new int[] { 0, 1, 1, 0 })); // 6
            // Console.WriteLine(binaryArrayToNumber(new int[] { 0, 1, 0, 1 })); // 5

            Console.WriteLine(intToBinaryString(9)); // 1001
            // Console.WriteLine(intToBinaryString(24)); // 11000
        }
        public static int binaryArrayToNumber(int[] BinaryArray)
        {
            string strValue = string.Join("", BinaryArray);

            return Convert.ToInt32(strValue, 2); ;
        }

        public static string intToBinaryString(int binaryNumber)
        {
            string value = Convert.ToString(binaryNumber, 2);

            return value;
        }
    }
}