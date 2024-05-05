namespace SquareLib;

public class AreaFinder
{
    public IShape Shape { get; set; }
    public AreaFinder(IShape shape)
    {
        Shape = shape;
    }

    public void GetArea()
    {
        Console.WriteLine(Shape.CalculateArea());
    }
}