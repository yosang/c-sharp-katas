using static System.Console;

// WriteLine(Solution("abc", "bc"));
// WriteLine(Solution("abc", "d"));

WriteLine(SolutionL("abc", "bc"));
WriteLine(SolutionL("abc", "d"));

bool Solution(string str, string ending)
{
    return str.EndsWith(ending);
}

// lambda operator

bool SolutionL(string str, string ending) => str.EndsWith(ending);