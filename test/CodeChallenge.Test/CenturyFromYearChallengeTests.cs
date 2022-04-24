using System;
using CodeChallenge.Challenges;
using FluentAssertions;
using Xunit;

namespace CodeChallenge.Test;

public class CenturyFromYearChallengeTests
{
    [Theory]
    [InlineData(1905, 20)]
    [InlineData(2005, 21)]
    public void CenturyFromYear_ValidYear_ReturnResult(int year, int expected)
    {
        //arrange
        var challenge = new CenturyFromYearChallenge();

        //act
        var result = challenge.Do(year);

        //assert
        result.Should().Be(expected);
    }

    [Fact]
    public void CenturyFromYear_InvalidYear_ReturnException()
    {
        //arrange
        var challenge = new CenturyFromYearChallenge();
        var year = 2010;

        //act
        Action result = () => challenge.Do(year);

        //assert
        result.Should().Throw<Exception>().WithMessage($"invalid year: {year}");
    }

}