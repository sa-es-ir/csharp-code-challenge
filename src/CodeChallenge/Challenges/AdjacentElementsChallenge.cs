namespace CodeChallenge.Challenges;

public class AdjacentElementsChallenge
{
    public int Do(int[] inputArray)
    {
        if (inputArray.Length is < 2 or > 10)
            throw new ArgumentOutOfRangeException(nameof(inputArray), "invalid array length");

        int maxValue = int.MinValue;
        for (int i = 0; i < inputArray.Length - 1; i++)
        {
            var j = i + 1;
            var value = inputArray[i] * inputArray[j];
            if (value > maxValue)
                maxValue = value;
        }

        return maxValue;
    }
}