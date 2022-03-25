public class LibraryDate
{
    int day;
    int month;
    int year;

    public LibraryDate(int day, int month, int year)
    {
        this.day = day;
        this.month = month;
        this.year = year;
    }

    public static int operator -(LibraryDate a, LibraryDate b)
    {
        int daysA = 0;
        int daysB = 0;
        daysA += a.year * 360 + a.month * 30 + a.day;
        daysB += b.year * 360 + b.month * 30 + b.day;
        return daysB - daysA;
    }
}