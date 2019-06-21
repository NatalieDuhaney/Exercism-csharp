using System;
using System.Collections.Generic;
using System.Text;

public class Program
{
    public static void Main(String[] args)
    {
        string output = Acronym.Abbreviate("Something - I made up from thin air");
        Console.WriteLine(output);
        Console.ReadKey();
    }
}

