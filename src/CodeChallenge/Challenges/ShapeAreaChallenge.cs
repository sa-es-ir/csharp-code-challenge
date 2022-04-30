namespace CodeChallenge.Challenges;

public class ShapeAreaChallenge
{
    public int Do(int n)
    {
        if (n is < 1 or > 10000)
            throw new Exception($"input should be between 1 to 10000 but current is {n}");

        if (n == 1)
            return 1;

        var center = n + (n - 1);
        var counter = center;

        while (counter > 1)
        {
            counter -= 2;
            center += 2 * counter;
        }

        return center;
    }
}