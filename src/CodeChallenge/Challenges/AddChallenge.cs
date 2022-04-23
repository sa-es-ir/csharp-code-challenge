namespace CodeChallenge.Challenges;

public class AddChallenge
{
    public int Do(int p1, int p2)
    {
        if (p1 is > 1000 or < -1000)
            throw new Exception($"Invalid inputs, param1={p1} should be in -1000<=param1<=1000");

        if (p2 is > 1000 or < -1000)
            throw new Exception($"Invalid inputs, param2={p2} should be in -1000<=param1<=1000");

        return p1 + p2;
    }
}