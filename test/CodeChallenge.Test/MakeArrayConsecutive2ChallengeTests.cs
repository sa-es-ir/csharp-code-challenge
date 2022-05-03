using CodeChallenge.Challenges;
using FluentAssertions;
using Xunit;

namespace CodeChallenge.Test;

public class MakeArrayConsecutive2ChallengeTests
{
    [Theory]
    [InlineData(new[] { 6, 2, 3, 8 }, 3)]
    [InlineData(new[] { 5, 2, 3, 1 }, 1)]
    [InlineData(new[] { 5, 2, 3, 10 }, 5)]
    public void MakeArrayConsecutive_InvalidInput_ReturnsResult(int[] items, int expected)
    {
        //arrange
        var challenge = new MakeArrayConsecutive2Challenge();

        //act
        var result = challenge.Do(items);

        //asset
        result.Should().Be(expected);
    }
}