using System;

public static class Leap
{
    public static bool IsLeapYear(int year)
    {
         bool DivisibleBy4   = year % 4   == 0; 
         bool DivisibleBy100 = year % 100 == 0; 
         bool DivisibleBy400 = year % 400 == 0; 
        
        return (DivisibleBy4) && (!DivisibleBy100 || DivisibleBy400) ? true : false;
    }
}
