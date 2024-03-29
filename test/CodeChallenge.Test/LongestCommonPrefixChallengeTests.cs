﻿using System;
using System.Collections.Generic;
using CodeChallenge.Challenges;
using FluentAssertions;
using Xunit;

namespace CodeChallenge.Test;

public class LongestCommonPrefixChallengeTests
{
    [Theory]
    [InlineData(new[] { "a", "abC", "abcD" }, "ab")]
    [InlineData(new[] { "a", "abC", "abcD", "abcwr" }, "abc")]
    [InlineData(new[] { "a", "bC", "g1bcD" }, "")]
    public void LongestCommonPrefix_ValidInput_ReturnResult(string[] array, string expected)
    {
        //arrange
        var challenge = new LongestCommonPrefixChallenge();

        //act
        var result = challenge.Do(array);

        //assert
        result.Should().Be(expected);
    }

    [Fact]
    public void LongestCommonPrefix_NullInput_ReturnArgumentNullException()
    {
        //arrange
        var challenge = new LongestCommonPrefixChallenge();

        //act
        Action result = () => challenge.Do(null!);

        //assert
        result.Should().Throw<ArgumentNullException>().WithParameterName("array");
    }
}