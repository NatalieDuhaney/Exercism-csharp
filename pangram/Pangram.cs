using System;
using System.Collections.Generic;

public static class Pangram
{
    /*this method creates a dictionary that contains a count of how many times 
      each of the characters a-z appears in the input string. If any character has
      a count of zero at the end it returns false, else returns true.*/
    public static bool IsPangram(string input)
    {       
        Dictionary<char, int> dct = new Dictionary<char, int>();
        dct.Add('a', 0);
        dct.Add('b', 0);
        dct.Add('c', 0);
        dct.Add('d', 0);
        dct.Add('e', 0);
        dct.Add('f', 0);
        dct.Add('g', 0);
        dct.Add('h', 0);
        dct.Add('i', 0);
        dct.Add('j', 0);
        dct.Add('k', 0);
        dct.Add('l', 0);
        dct.Add('m', 0);
        dct.Add('n', 0);
        dct.Add('o', 0);
        dct.Add('p', 0);
        dct.Add('q', 0);
        dct.Add('r', 0);
        dct.Add('s', 0);
        dct.Add('t', 0);
        dct.Add('u', 0);
        dct.Add('v', 0);
        dct.Add('w', 0);
        dct.Add('x', 0);
        dct.Add('y', 0);
        dct.Add('z', 0);

        foreach (var i in input.ToLower())
        {
            if (dct.ContainsKey(i))
            {
                dct[i]+= 1;
            }
        }

        return dct.ContainsValue(0) ? false : true;

    }

}



