namespace SquareLib;
public class Circle : IShape
{
    public double Radius { get; private set; }
    public Circle(double radius)
    {
        if (radius <= 0)
        {
            throw new ArgumentException("Radius can't be less or equal to zero");
        }
        Radius = radius;
    }

    public double CalculateArea()
    {
        double area = Math.PI * Math.Pow(Radius, 2);

        return area;
    }
}
