using CodeChallenge.Challenges;
using FluentAssertions;
using Xunit;

namespace CodeChallenge.Test;

public class CenturyFromYearChallengeTests
{

    [Theory]
    [InlineData(1905, 20)]
    [InlineData(2009, 21)]
    public void CenturyFromYear_ValidYear_ReturnResult(int year, int expected)
    {
        //arrange
        var challenge = new CenturyFromYearChallenge();

        //act
        var result = challenge.Do(year);

        //assert
        result.Should().Be(expected);
    }
}