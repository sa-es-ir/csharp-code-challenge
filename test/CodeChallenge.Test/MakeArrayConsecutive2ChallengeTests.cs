using System;
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
    public void MakeArrayConsecutive_ValidInput_ReturnsResult(int[] items, int expected)
    {
        //arrange
        var challenge = new MakeArrayConsecutive2Challenge();

        //act
        var result = challenge.Do(items);

        //asset
        result.Should().Be(expected);
    }

    [Fact]
    public void MakeArrayConsecutive_InValidInputLength_ReturnsArgumentException()
    {
        //arrange
        var challenge = new MakeArrayConsecutive2Challenge();

        //act
        Action result = () => challenge.Do(Array.Empty<int>());

        //asset
        result.Should().Throw<ArgumentException>().WithMessage("input array length is not valid");
    }

    [Fact]
    public void MakeArrayConsecutive_InValidInputItem_ReturnsArgumentException()
    {
        //arrange
        var challenge = new MakeArrayConsecutive2Challenge();
        var input = new[] { -1, 10, 10, 9 };
        //act
        Action result = () => challenge.Do(input);

        //asset
        result.Should().Throw<ArgumentException>().WithMessage("input array item is not valid");
    }
}