using static System.Math;
namespace Calculation.Figure;

public class Circle : Shape
{
    private readonly double Radius;

    public Circle(double radius)
    {
        Radius = radius;
    }

    /// <summary>
    /// Вычисление площади окружности
    /// </summary>
    /// <returns></returns>
    public override double CalculateArea()
    {
        return Round(PI * Pow(Radius, 2), 2);
    }
}


