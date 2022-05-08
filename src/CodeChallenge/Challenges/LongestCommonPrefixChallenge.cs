namespace CodeChallenge.Challenges;

public class LongestCommonPrefixChallenge
{
    public string Do(string[] array)
    {
        if (array == null) throw new ArgumentNullException(nameof(array));

        return Enumerable.Range(1, array.Max(_ => _)!.Length)
            .Select(i =>
            {
                var grouped = array.Where(x => x.Length >= i)
                    .GroupBy(x => x[..i])
                    .Where(x => x.Count() > 1)
                    .OrderByDescending(x => x.Count())
                    .Select(x => new { LongestCommonPrefix = x.Key })
                    .FirstOrDefault();

                return grouped?.LongestCommonPrefix ?? string.Empty;
            }).Max()!;
    }
}