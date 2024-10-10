using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathLibrary.Tests;

public class MathOperationsTests
{
    [Theory]
    [InlineData(5, 5, 10)]
    [InlineData(5, -4, 1)]
    [InlineData(-5, 4, -1)]
    public void AddShouldReturnSumOfTwoDoubles(double x, double y, double expected)
    {
        double actual = MathOperations.Add(x, y);

        Assert.Equal(expected, actual);
    }
    [Theory]
    [InlineData(5, 5, 0)]
    [InlineData(4, 5, -1)]
    [InlineData(5, 4, 1)]
    public void SubtractShouldReturnDifferenceOfTwoDoubles(double x, double y, double expected)
    {
        double actual = MathOperations.Subtract(x, y);

        Assert.Equal(expected, actual);
    }
    [Theory]
    [InlineData(5, 5, 25)]
    [InlineData(-5, -5, 25)]
    [InlineData(5, -5, -25)]
    [InlineData(-5, 5, -25)]
    [InlineData(5, 0, 0)]
    [InlineData(0, 5, 0)]
    public void MultiplyShouldReturnProductOfTwoDoubles(double x, double y, double expected)
    {
        double actual = MathOperations.Multiply(x, y);

        Assert.Equal(expected, actual);
    }
    [Theory]
    // Arrange
    [InlineData(5, 5, 1)]
    [InlineData(-5, -5, 1)]
    [InlineData(-5, 5, -1)]
    [InlineData(5, -5, -1)]
    [InlineData(0, 5, 0)]
    [InlineData(-120, 4, -30)]
    public void DivideShouldReturnQuotientOfTwoDoubles(int x, int y, int expected)
    {
        // Act
        int actual = MathOperations.Divide(x, y);

        // Assert
        Assert.Equal(expected, actual);
    }
    [Fact]
    public void DivideShouldReturnDivideByZeroException()
    {
        // Arrange 
        string expected = "Cannot divide by zero";

        // Act
        Action act = () => MathOperations.Divide(5, 0);

        // Assert
        DivideByZeroException ex = Assert.Throws<DivideByZeroException>(() => act());
        Assert.Equal(expected, ex.Message);
    }
}

