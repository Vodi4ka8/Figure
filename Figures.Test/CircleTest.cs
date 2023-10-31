using Calculation.Figure;
using Xunit;
namespace Calculation.Test;

public class CircleTest
{
    [Fact]
    public void CalculateArea_Shoul_Be_Correct()
    {
        Circle circle = new(24);

        var result = circle.CalculateArea();

        var area = 1809.56;

        Assert.Equal(area, result);
    }

    [Fact]
    public void CalculateArea_Shoul_Be_Wrong()
    {
        Circle circle = new(24);

        var result = circle.CalculateArea();

        var area = 1234;

        Assert.NotEqual(area, result);
    }
}
