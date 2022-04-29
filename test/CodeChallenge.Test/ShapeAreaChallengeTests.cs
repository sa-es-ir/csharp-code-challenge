using System;
using CodeChallenge.Challenges;
using FluentAssertions;
using Xunit;

namespace CodeChallenge.Test;

public class ShapeAreaChallengeTests
{
    [Theory]
    [InlineData(2, 5)]
    [InlineData(3, 13)]
    public void ShapeArea_ValidInput_ReturnResult(int n, int expected)
    {
        //arrange
        var challenge = new ShapeAreaChallenge();

        //act
        var result = challenge.Do(n);

        //assert
        result.Should().Be(expected);
    }

    [Fact]
    public void ShapeArea_InvalidInput_ReturnException()
    {
        //arrange
        var challenge = new ShapeAreaChallenge();
        var input = 100000;

        //act
        Action result = () => challenge.Do(input);

        //assert
        result.Should().Throw<Exception>()
            .WithMessage($"int should be between 1 to 10000 but current is {input}");
    }
}