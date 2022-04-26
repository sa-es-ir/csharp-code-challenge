using System;
using CodeChallenge.Challenges;
using FluentAssertions;
using Xunit;

namespace CodeChallenge.Test;

public class CheckPalindromeTests
{

    [Theory]
    [InlineData("aabaa", true)]
    [InlineData("a", true)]
    [InlineData("abac", false)]
    [InlineData("cccc", true)]
    public void CheckPalindrome_ValidInput_ReturnResult(string input, bool expected)
    {
        //arrange
        var challenge = new CheckPalindrome();

        //act
        var result = challenge.Do(input);

        //assert
        result.Should().Be(expected);
    }

    [Fact]
    public void CheckPalindrome_InvalidEmptyInput_ReturnException()
    {
        //arrange
        var challenge = new CheckPalindrome();
        var input = string.Empty;

        //act
        Action result = () => challenge.Do(input);

        //assert
        result.Should().Throw<ArgumentException>().WithMessage("input is empty");
    }

    [Fact]
    public void CheckPalindrome_InvalidLowerCaseInput_ReturnException()
    {
        //arrange
        var challenge = new CheckPalindrome();
        var input = "AvbRd";

        //act
        Action result = () => challenge.Do(input);

        //assert
        result.Should().Throw<ArgumentException>().WithMessage("input should be lowercase");
    }
}