namespace CodeChallenge.Challenges;

public class CenturyFromYearChallenge
{
    public int Do(int year)
    {
        if (year is < 1 or > 2005)
            throw new ArgumentException($"invalid year: {year}");

        var century = year / 100;
        var remain = year % 100;

        if (remain > 0)
            century++;

        return century;
    }
}