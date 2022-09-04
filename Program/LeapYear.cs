namespace Leap;

public class LeapYear
{
    public bool isLeapYear(int year)
    {
        if (year % 4 != 0) return false;
        return true;

    }
}