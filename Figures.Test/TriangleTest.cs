using System;
using Calculation.Figure;
using Xunit;

namespace CalculationFigures.Test
{

    public class TriangleTest
    {
        [Fact]
        public void CalculateArea_Shoul_Be_Correct()
        {
            
            var triangle = new Triangle(3, 4, 5);

            var area = 6;

            var result = triangle.CalculateArea();

            Assert.Equal(area, result);
        }

        [Fact]
        public void CalculateArea_Should_Be_Wrong()
        {
            var triangle = new Triangle(3, 4, 5);

            var area = 12;

            var result = triangle.CalculateArea();

            Assert.NotEqual(area, result);
        }

        [Fact]
        public void IsReactangle_Should_Return_False()
        {
            var triangle = new Triangle(4, 4, 2);

            var result = triangle.IsRectangular();

            Assert.False(result);
        }

        [Fact]
        public void IsReactangle_Should_Return_True()
        {
            var triangle = new Triangle(3, 4, 5);

            var result = triangle.IsRectangular();

            Assert.True(result);
        }
    }
}

