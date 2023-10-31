using static System.Math;
namespace Calculation.Figure;

public class Triangle : Shape
{
    private readonly double ASide;
    private readonly double BSide;
    private readonly double CSide;

    public Triangle(double aSide, double bSide, double cSide)
    {
        if (aSide < 0 || bSide < 0 || cSide < 0)
        throw new ArgumentException("Error : one of the values is less than zero");

        ASide = aSide;
        BSide = bSide;
        CSide = cSide;
    }

    /// <summary>
    /// вычисление площади треугольника по формуле Герона;
    /// </summary>
    /// <returns></returns>
    public override double CalculateArea()
    {
        var perimeter = (ASide + BSide + CSide) / 2;

        var area = Round(Sqrt(perimeter
            * (perimeter - ASide)
            * (perimeter - BSide)
            * (perimeter - CSide)), 1);

        return area;
    }

    /// <summary>
    /// Проверка треугольника на перпендикулярность;
    /// </summary>
    /// <returns></returns>
    public bool IsRectangular()
    {
        if (Pow(ASide, 2) + Pow(BSide, 2) == Pow(CSide, 2) 
           || (Pow(ASide, 2) + Pow(CSide, 2) == Pow(BSide, 2)) 
           || (Pow(CSide, 2) + Pow(BSide, 2) == Pow(ASide, 2)))
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}


