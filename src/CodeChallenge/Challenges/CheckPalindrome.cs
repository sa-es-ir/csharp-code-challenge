namespace CodeChallenge.Challenges;

public class CheckPalindrome
{
    public bool Do(string inputString)
    {
        if (string.IsNullOrEmpty(inputString))
            throw new ArgumentException("input is empty");

        if (inputString != inputString.ToLower())
            throw new ArgumentException("input should be lowercase");

        if (inputString.Length is < 1 or > 100_000)
            throw new ArgumentException("input length is not valid");

        if (inputString.Length is 1)
            return true;

        var halfOne = inputString[..(inputString.Length / 2)];

        var temp = new string(inputString.Reverse().ToArray());
        var halfTwo = temp[..(temp.Length / 2)];

        return halfOne == halfTwo;
    }
}