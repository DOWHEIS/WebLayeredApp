using Xunit;
namespace LogicLibary.Tests;

public class FactorialTests
{
    [Fact]
    public void FactorialZero()
    {
        Assert.Equal(1, LogicLibrary.FactorialService.Factorial(0));
    }
    [Fact]
    public void Negative()
    {
        Assert.Throws<Exception>(() =>
        {
            LogicLibrary.FactorialService.Factorial(-2);
        });
    }

    [Fact]
    public void FactorialFive()
    {
        Assert.Equal(120, LogicLibrary.FactorialService.Factorial(5));
    }
}