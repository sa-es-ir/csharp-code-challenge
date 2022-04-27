namespace CodeChallenge.Challenges;

public class AdjacentElementsChallenge
{
    public int Do(int[] inputArray)
    {
        if (inputArray.Length is < 2 or > 10)
            throw new ArgumentOutOfRangeException(nameof(inputArray), "invalid array length");

        return inputArray.Select((i, j) => j > 0 ? i * inputArray[j - 1] : int.MinValue).Max();
    }
}