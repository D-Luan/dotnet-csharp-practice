namespace GeometricShapesExercise;

public class Circle : IShape
{
    private const decimal PI = 3.14159m;

    public decimal Radius { get; private set; }

    public Circle(decimal radius)
    {
        if (radius <= 0) throw new ArgumentException("Radius must be greater than 0");
        Radius = radius;
    }

    public decimal CalculateArea() => PI * Radius * Radius;

    public string GetName() => "Circle";

    public void DisplayInfo()
    {
        Console.WriteLine($"Shape: {GetName()}");
        Console.WriteLine($"Radius: {Radius:F2}");
        Console.WriteLine($"Area: {CalculateArea():F2}");
    }
}
