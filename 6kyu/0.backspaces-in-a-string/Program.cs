using System.Collections.Generic;

namespace Program
{
    public class App
    {
        public class TextCannotBeEmpty : Exception
        {
            public TextCannotBeEmpty(string message) : base(message) { }
        }

        public static string ProcessBackspaces(string text, char symbol = '#')
        {
            // No point in processing an empty string, so just throw an exception if its empty before moving on
            if (text.Length < 1) throw new TextCannotBeEmpty("Text cannot be empty");

            Stack<char> myStack = new Stack<char>(); // We are using a stack for the backspacing = everytime we encounter a symbol, we pop from the stack, otherwise push

            // Iterate each character of the text string, if its not a #, push it to our stack
            // Otherwise check if we have items in our stack, and remove pop them each time we encounter a #
            foreach (char c in text)
            {
                if (c != symbol)
                {
                    myStack.Push(c);
                }
                else
                {
                    if (myStack.Count > 0) myStack.Pop(); // Make sure we pop only if there are items in the stack
                }
            }

            // We can reverse a stack by creating a new stack from the original stack

            return string.Join("", new Stack<char>(myStack));
        }
        public static void Main()
        {
            string test1 = ProcessBackspaces("abc#d##c");
            string test2 = ProcessBackspaces("abc##d######"); // should return and empty string
            string test3 = ProcessBackspaces("#######");
            // string test4 = ProcessBackspaces(""); // throws an exception

            Console.WriteLine(test1);
            Console.WriteLine(test2);
            Console.WriteLine(test3);
            // Console.WriteLine(test4);
        }
    }
}