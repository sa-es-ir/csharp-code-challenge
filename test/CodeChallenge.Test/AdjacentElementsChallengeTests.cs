using System;
using CodeChallenge.Challenges;
using FluentAssertions;
using Xunit;

namespace CodeChallenge.Test;

public class AdjacentElementsChallengeTests
{
    [Theory]
    [InlineData(new[] { 3, 6, -2, -5, 7, 3 }, 21)]
    [InlineData(new[] { -1, -2, -3 }, 6)]
    [InlineData(new[] { -1, 2, -3 }, -2)]
    public void AdjacentElements_ValidInput_ReturnResult(int[] input, int expected)
    {
        //arrange
        var challenge = new AdjacentElementsChallenge();

        //act
        var result = challenge.Do(input);

        //assert
        result.Should().Be(expected);
    }

    [Fact]
    public void AdjacentElement_InvalidArrayLength_ReturnArgumentOutOfRangeException()
    {
        //arrange
        var challenge = new AdjacentElementsChallenge();
        var inputArray = new[] { 1 };

        //act
        Action result = () => challenge.Do(inputArray);

        //assert
        result.Should().Throw<ArgumentOutOfRangeException>()
            .WithParameterName(nameof(inputArray))
            .WithMessage($"invalid array length (Parameter '{nameof(inputArray)}')");
    }

    [Fact]
    public void AdjacentElement_InvalidArrayItem_ReturnException()
    {
        //arrange
        var challenge = new AdjacentElementsChallenge();
        var inputArray = new[] { 1, 2, -1100 };

        //act
        Action result = () => challenge.Do(inputArray);

        //assert
        result.Should().Throw<Exception>()
            .WithMessage("invalid array item");
    }
}