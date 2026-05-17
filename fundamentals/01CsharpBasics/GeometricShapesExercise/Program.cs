using GeometricShapesExercise;

List<IShape> shapes = new List<IShape>();

shapes.Add(new Rectangle(10, 5));
shapes.Add(new Circle(4));
shapes.Add(new Rectangle(7, 3));

foreach (IShape shape in shapes)
{
    shape.DisplayInfo();
    Console.WriteLine();
}

try
{
    shapes.Add(new Rectangle(-3, 10));
}
catch (ArgumentException ex)
{
    Console.WriteLine($"Error: {ex.Message}");
}

try
{
    shapes.Add(new Rectangle(3, 0));
}
catch (ArgumentException ex)
{
    Console.WriteLine($"Error: {ex.Message}");
}

try
{
    shapes.Add(new Circle(0));
}
catch (ArgumentException ex)
{
    Console.WriteLine($"Error: {ex.Message}");
}