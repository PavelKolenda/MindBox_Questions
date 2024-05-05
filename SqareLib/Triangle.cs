namespace SquareLib;
public class Triangle : ITriangle
{
    public double SideA { get; private set; }
    public double SideB { get; private set; }
    public double SideC { get; private set; }
    public Triangle(double sideA, double sideB, double sideC)
    {
        if (sideA <= 0 || sideB <= 0 || sideC <= 0)
        {
            throw new ArgumentException("Sides must be greater than zero");
        }

        SideA = sideA;
        SideB = sideB;
        SideC = sideC;
    }

    public double CalculateArea()
    {
        double p = (SideA + SideB + SideC) / 2;

        double area = Math.Sqrt(p * (p - SideA) * (p - SideB) * (p - SideC));

        return area;
    }

    public bool IsRight()
    {
        double hypotenuse = Math.Max(SideA, Math.Max(SideB, SideC));
        double side1, side2;

        if (hypotenuse == SideA)
        {
            side1 = SideB;
            side2 = SideC;
        }
        else if (hypotenuse == SideB)
        {
            side1 = SideA;
            side2 = SideC;
        }
        else
        {
            side1 = SideA;
            side2 = SideB;
        }

        return hypotenuse * hypotenuse == side1 * side1 + side2 * side2;
    }
}