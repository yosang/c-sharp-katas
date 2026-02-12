using System.Text;
using static System.Console;

/* 
Theres two ways we can do this.

Method 1: 
- Convert the string to an array of characters, String.ToCharArray is a method we can use to achieve this
- Use the Array.Reverse method to reverse the new array
- Convert the new reversed array back to a string

Method 2:
- Loop through the string, starting from the last character
- Construct a new string, the class StringBuilder is efficient, use the Append method to append characters to the stringbuilder
- Use the StringBuilder method ToString to join it all together

*/

WriteLine(methodOne("hello"));
WriteLine(methodTwo("hello"));

string methodOne(string s)
{
    char[] characters = s.ToCharArray();
    Array.Reverse(characters);
    string result = new string(characters);

    return result;
}

string methodTwo(string s)
{
    StringBuilder sb = new StringBuilder(); // empty StringBuilder, we are going to add items on the loop;

    for (int i = s.Length - 1; i >= 0; i--)
    {
        sb.Append(s[i]);
    }

    string result = sb.ToString();

    return result;
}