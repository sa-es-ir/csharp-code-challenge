namespace CodeChallenge.Challenges;

public class ShapeAreaChallenge
{
    public int Do(int n)
    {
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