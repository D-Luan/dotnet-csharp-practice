namespace GeometricShapesExercise;

public class Rectangle : IShape
{
    public decimal Width { get; private set; }
    public decimal Height { get; private set; }

    public Rectangle(decimal width, decimal height)
    {
        if (width <= 0) throw new ArgumentException("Width must be greater than 0");

        if (height <= 0) throw new ArgumentException("Height must be greater than 0");

        Width = width;
        Height = height;
    }

    public decimal CalculateArea() => Width * Height;

    public string GetName() => "Rectangle";

    public void DisplayInfo()
    {
        Console.WriteLine($"Shape: {GetName()}");
        Console.WriteLine($"Width: {Width:F2}");
        Console.WriteLine($"Height: {Height:F2}");
        Console.WriteLine($"Area: {CalculateArea():F2}");
    }
}
