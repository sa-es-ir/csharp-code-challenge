namespace CodeChallenge.Challenges;

public class LongestCommonPrefixChallenge
{
    public string Do(List<string> array)
    {
        if (array == null) throw new ArgumentNullException(nameof(array));

        array = array.OrderBy(_ => _).ToList();

        int longestCount = 1;
        string longestPrefix = string.Empty;
        for (int i = 1; i <= array.Max(_ => _)?.Length; i++)
        {
            var grouped = array.Where(x => x.Length >= i)
                .GroupBy(x => x[..i])
                .Where(x => x.Count() > 1)
                .OrderByDescending(x => x.Count())
                .Select(x => new { LongestCommonPrefix = x.Key, LongestCommonPrefixCount = x.Count() })
                .FirstOrDefault();

            if (grouped == null)
                break;

            if (grouped.LongestCommonPrefix.Length > longestPrefix.Length)
            {
                longestCount = grouped.LongestCommonPrefixCount;
                longestPrefix = grouped.LongestCommonPrefix;
            }
        }

        return longestPrefix;

    }
}