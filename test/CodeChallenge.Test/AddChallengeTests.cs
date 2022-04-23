using System;
using CodeChallenge.Challenges;
using FluentAssertions;
using Xunit;

namespace CodeChallenge.Test;

public class AddChallengeTests
{

    [Theory]
    [InlineData(1, 3, 4)]
    [InlineData(100, -45, 55)]
    [InlineData(-10, 10, 0)]
    public void Add_ValidParams_ReturnSum(int p1, int p2, int expected)
    {
        //arrange
        var challenge = new AddChallenge();

        //act
        var result = challenge.Do(p1, p2);

        //assert
        result.Should().Be(expected);
    }

    [Fact]
    public void Add_InvalidFirstParam_ReturnException()
    {
        //arrange
        var p1 = -2000;
        var p2 = 10;
        var challenge = new AddChallenge();

        //act
        Action result = () => challenge.Do(p1, p2);

        //assert
        result.Should().Throw<Exception>().WithMessage($"Invalid inputs, param1={p1} should be in -1000<=param1<=1000");
    }


    [Fact]
    public void Add_InvalidSecondParam_ReturnException()
    {
        //arrange
        var p1 = 400;
        var p2 = 10000;
        var challenge = new AddChallenge();

        //act
        Action result = () => challenge.Do(p1, p2);

        //assert
        result.Should().Throw<Exception>().WithMessage($"Invalid inputs, param2={p2} should be in -1000<=param1<=1000");
    }
}