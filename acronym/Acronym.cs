using System;

public static class Acronym
{
    public static string Abbreviate(string phrase)
    {
        string   acronymn = "";
        string[] words    = phrase.Split(" ");

        foreach (string w in words)
        {
            Console.WriteLine(w);
            acronymn += w[0];
        }

        Console.WriteLine(acronymn.ToUpper());
        return acronymn.ToUpper();
    }
}
