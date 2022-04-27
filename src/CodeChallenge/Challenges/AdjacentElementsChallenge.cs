namespace CodeChallenge.Challenges;

public class AdjacentElementsChallenge
{
    public int Do(int[] inputArray)
    {
        if (inputArray.Length is < 2 or > 10)
            throw new ArgumentOutOfRangeException(nameof(inputArray), "invalid array length");

        if (inputArray.Any(x => x is < -1000 or > 1000))
            throw new Exception("invalid array item");

        return inputArray.Select((i, j) => j > 0 ? i * inputArray[j - 1] : int.MinValue).Max();
    }
}