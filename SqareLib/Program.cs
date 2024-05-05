using SquareLib;

AreaFinder areaFinder = new(new Circle(6));
areaFinder.GetArea();
areaFinder.Shape = new Triangle(5, 6, 7);
TriangleUtils triangleUtils = new(new Triangle(3, 4, 5));
Console.WriteLine(triangleUtils.IsRight());
areaFinder.GetArea();
areaFinder.Shape = new Square(6);
areaFinder.GetArea();