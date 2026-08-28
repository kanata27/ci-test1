using CiTest.Api;

namespace CiTest.Tests;

public class CalculatorTests
{
    [Fact]
    public void Add_ReturnsCorrectResult()
    {
        var result = Calculator.Add(2, 3);

        Assert.Equal(5, result);
    }
}
