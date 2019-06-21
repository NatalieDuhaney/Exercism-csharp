using System;

public static class Grains
{
    public static ulong Square(int n) => (ulong)Math.Pow(2, n-1);

    public static ulong Total()
    {
        ulong total = 0; 

        for (int x = 1; x < 65; x++)
        {
            total+=Square(x);
        }

        return total;
    }
}