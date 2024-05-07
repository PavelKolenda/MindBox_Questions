namespace SquareLib.Tests;
public class UnitTests
{

    [Fact]
    public void Circle_CalculateArea()
    {
        //arrange
        IShape shape = new Circle(5);
        //act
        double expected = 78.53981633974483;
        //assert
        Assert.Equal(expected, shape.CalculateArea());
    }

    [Fact]
    public void Triangle_CalculateArea()
    {
        //arrange
        IShape shape = new Triangle(5, 6, 7);
        //act
        double expected = 14.696938456699069;
        //assert
        Assert.Equal(expected, shape.CalculateArea());
    }

    [Fact]
    public void Triangle_IsRight_ShouldReturnTrue()
    {
        //arrange
        ITriangle triangle = new Triangle(3, 4, 5);
        //act
        bool expected = true;
        //assert
        Assert.Equal(expected, triangle.IsRight());
    }

    [Fact]
    public void Triangle_IsRight_ShouldReturnFalse()
    {
        //arrange
        ITriangle triangle = new Triangle(5, 5, 5);
        //act
        bool expected = false;
        //assert
        Assert.Equal(expected, triangle.IsRight());
    }

    [Fact]
    public void Circle_InvalidRadius_ShouldThrowArgumentException()
    {
        Assert.Throws<ArgumentException>(() => new Circle(-1));
    }
    [Fact]
    public void Triangle_InvalidSidesLength_ShouldThrowArgumentException()
    {
        Assert.Throws<ArgumentException>(() => new Triangle(-1, 3, 4));
    }

    [Fact]
    public void Square_InvalidSideLength_ShouldThrowArgumentException()
    {
        Assert.Throws<ArgumentException>(() => new Square(0));
    }
}
