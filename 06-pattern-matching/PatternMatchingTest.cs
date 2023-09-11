using NUnit.Framework;

using functional_programming;

[TestFixture]
public class PatternMatchingTests
{
    [Test]
    public void ReturnDescriptionOfShape_ReturnsCorrectDescriptionForSmallRectangle()
    {
        // Arrange
        object shape = new Rectangle(2, 1);
        int length = 2;
        int height = 1;

        // Act
        string result = Shapes.ReturnDescriptionOfShape(shape, length, height);

        // Assert
        Assert.AreEqual("This is a small rectangle", result);
    }

    [Test]
    public void ReturnDescriptionOfShape_ReturnsCorrectDescriptionForBigTriangle()
    {
        // Arrange
        object shape = new Triangle(20, 10);
        int length = 20;
        int height = 10;

        // Act
        string result = Shapes.ReturnDescriptionOfShape(shape, length, height);

        // Assert
        Assert.AreEqual("This is a big triangle", result);
    }

    [Test]
    public void ReturnDescriptionOfShape_ReturnsCorrectDescriptionForSquareWithLength10()
    {
        // Arrange
        object shape = new Square(10);
        int length = 10;
        int height = 0;

        // Act
        string result = Shapes.ReturnDescriptionOfShape(shape, length, height);

        // Assert
        Assert.AreEqual("Square with length 10", result);
    }

    [Test]
    public void ReturnDescriptionOfShape_ReturnsUnknownForUnknownShape()
    {
        // Arrange
        object shape = "Unknown";
        int length = 0;
        int height = 0;

        // Act
        string result = Shapes.ReturnDescriptionOfShape(shape, length, height);

        // Assert
        Assert.AreEqual("Unknown", result);
    }

    [Test]
    public void ReturnDescriptionOfShapeWithRelationalPattern_ReturnsCorrectDescriptionForSmallRectangle()
    {
        // Arrange
        object shape = new Rectangle(5, 2);

        // Act
        string result = Shapes.ReturnDescriptionOfShapeWithRelationalPattern(shape);

        // Assert
        Assert.AreEqual("This is a small rectangle", result);
    }

    [Test]
    public void ReturnDescriptionOfShapeWithRelationalPattern_ReturnsCorrectDescriptionForBigTriangle()
    {
        // Arrange
        object shape = new Triangle(10, 20);

        // Act
        string result = Shapes.ReturnDescriptionOfShapeWithRelationalPattern(shape);

        // Assert
        Assert.AreEqual("This is a big triangle", result);
    }

    [Test]
    public void ReturnDescriptionOfShapeWithRelationalPattern_ReturnsCorrectDescriptionForSquareWithLength10()
    {
        // Arrange
        object shape = new Square(10);

        // Act
        string result = Shapes.ReturnDescriptionOfShapeWithRelationalPattern(shape);

        // Assert
        Assert.AreEqual("Square with length 10", result);
    }

    [Test]
    public void ReturnDescriptionOfShapeWithRelationalPattern_ReturnsUnknownForUnknownShape()
    {
        // Arrange
        object shape = "Unknown";

        // Act
        string result = Shapes.ReturnDescriptionOfShapeWithRelationalPattern(shape);

        // Assert
        Assert.AreEqual("Unknown", result);
    }

    [Test]
    public void CalculateArea_ReturnsCorrectAreaForRectangle()
    {
        // Arrange
        object shape = new Rectangle(5, 2);

        // Act
        double result = Shapes.CalculateArea(shape);

        // Assert
        Assert.AreEqual(10, result);
    }

    [Test]
    public void CalculateArea_ReturnsCorrectAreaForCircle()
    {
        // Arrange
        object shape = new Circle(5);

        // Act
        double result = Shapes.CalculateArea(shape);

        // Assert
        Assert.AreEqual(Math.PI * 25, result);
    }

    [Test]
    public void CalculateArea_ReturnsCorrectAreaForSquare()
    {
        // Arrange
        object shape = new Square(5);

        // Act
        double result = Shapes.CalculateArea(shape);

        // Assert
        Assert.AreEqual(25, result);
    }

    [Test]
    public void CalculateArea_ReturnsCorrectAreaForTriangle()
    {
        // Arrange
        object shape = new Triangle(5, 2);

        // Act
        double result = Shapes.CalculateArea(shape);

        // Assert
        Assert.AreEqual(5, result);
    }

    [Test]
    public void CalculateArea_ThrowsArgumentExceptionForUnknownShape()
    {
        // Arrange
        object shape = "Unknown";

        // Act & Assert
        Assert.Throws<ArgumentException>(() => Shapes.CalculateArea(shape));
    }
}