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
}