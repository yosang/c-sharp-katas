using System.Collections.Generic;
public static class Kata
{

    public static void Main()
    {
        Console.WriteLine(Greet("norsk")); // Welcome, norsk is not in the database
        Console.WriteLine(Greet("finnish")); // Tervetuloa
    }
    public static string Greet(string language)
    {
        // We can use a Dictionary for key:value lookups
        Dictionary<string, string> database = new Dictionary<string, string>()
        {
                {"english", "Welcome"}
            , {"czech", "Vitejte"}
            , {"danish", "Velkomst"}
            , {"dutch", "Welkom"}
            , {"estonian", "Tere tulemast"}
            , {"finnish", "Tervetuloa"}
            , {"flemish", "Welgekomen"}
            , {"french", "Bienvenue"}
            , {"german", "Willkommen"}
            , {"irish", "Failte"}
            , {"italian", "Benvenuto"}
            , {"latvian", "Gaidits"}
            , {"lithuanian", "Laukiamas"}
            , {"polish", "Witamy"}
            , {"spanish", "Bienvenido"}
            , {"swedish", "Valkommen"}
            , {"welsh", "Croeso"}
        };

        string greeting;

        // We check if the passed language is in our database with .ContainsKey()
        // If it does, return the greeting, if it doesnt default to english
        greeting = database.ContainsKey(language) ? database[language] : database["english"];

        return greeting;
    }


}