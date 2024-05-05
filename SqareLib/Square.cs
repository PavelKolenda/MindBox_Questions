
namespace SquareLib;
/// <summary>
/// Ease of adding other figures
/// </summary>
public class Square : IShape
{
    public double Side { get; set; }
    public Square(double side)
    {
        if (side <= 0)
        {
            throw new ArgumentException("Side must be greater than zero");
        }

        Side = side;
    }

    public double CalculateArea()
    {
        return Side * Side;
    }
}