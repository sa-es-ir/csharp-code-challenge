namespace CodeChallenge.Challenges;

public class CheckPalindromeChallenge
{
    public bool Do(string inputString)
    {
        if (string.IsNullOrEmpty(inputString))
            throw new ArgumentException("input is empty");

        if (inputString != inputString.ToLower())
            throw new ArgumentException("input should be lowercase");

        if (inputString.Length is < 1 or > 100_000)
            throw new ArgumentException("input length is not valid");

        return inputString.SequenceEqual(inputString.Reverse());
    }
}