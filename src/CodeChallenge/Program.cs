
using CodeChallenge.Challenges;

Console.WriteLine("Hello, World!");

var commonPrefix = new LongestCommonPrefixChallenge();
var result = commonPrefix.Do(new List<string>() { "a", "a3bC", "a2bcD", "abcz" });

Console.Read();
