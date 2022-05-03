namespace CodeChallenge.Challenges;

public class MakeArrayConsecutive2Challenge
{
    public int Do(int[] statues)
    {
        if (statues.Length is < 1 or > 10)
            throw new ArgumentException("statues length is not valid");

        if (statues.Any(x => x is < 0 or > 20))
            throw new ArgumentException("statues item is not valid");

        if (statues.Length == 1)
            return 0;

        statues = statues.OrderBy(x => x).ToArray();

        var needCount = 0;
        for (var i = 0; i < statues.Length - 1; i++)
        {
            var j = i + 1;
            var diff = statues[j] - statues[i];

            if (diff > 1)
                needCount += diff - 1;

        }

        return needCount;
    }
}