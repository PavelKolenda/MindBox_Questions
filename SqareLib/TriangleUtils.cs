namespace SquareLib;

public class TriangleUtils
{
    public ITriangle Triangle { get; private set; }

    public TriangleUtils(ITriangle triangle)
    {
        Triangle = triangle;
    }

    public bool IsRight()
    {
        return Triangle.IsRight();
    }
}
