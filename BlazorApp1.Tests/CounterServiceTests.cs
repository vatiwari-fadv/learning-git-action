using BlazorApp1.Services;
using Xunit;

namespace BlazorApp1.Tests;

public class CounterServiceTests
{
    [Fact]
    public void CurrentCount_StartsAtZero()
    {
        var service = new CounterService();

        Assert.Equal(0, service.CurrentCount);
    }

    [Fact]
    public void Increment_IncreasesByOne_ByDefault()
    {
        var service = new CounterService();

        var result = service.Increment();

        Assert.Equal(1, result);
        Assert.Equal(1, service.CurrentCount);
    }

    [Theory]
    [InlineData(5, 5)]
    [InlineData(-2, -2)]
    [InlineData(10, 10)]
    public void Increment_WithAmount_AddsThatAmount(int by, int expected)
    {
        var service = new CounterService();

        var result = service.Increment(by);

        Assert.Equal(expected, result);
    }

    [Fact]
    public void Reset_SetsCountBackToZero()
    {
        var service = new CounterService();
        service.Increment(42);

        service.Reset();

        Assert.Equal(0, service.CurrentCount);
    }
}
