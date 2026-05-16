using ProductAndStockExercise;

Product product = new Product("Playstation 4", 1200, 50);
product.DisplayData();
Console.WriteLine();

product.AddStock(5);
product.RemoveStock(3);
product.DisplayData();
Console.WriteLine();

Console.WriteLine($"Product is available? {(product.IsAvailable() ? "Yes" : "No")}");
Console.WriteLine($"Total value in stock: R$ {product.GetTotalValueInStock():F2}");

try
{
    product.AddStock(-33);
}
catch (ArgumentException ex)
{
    Console.WriteLine($"Error: {ex.Message}");
}

try
{
    product.RemoveStock(0);
}
catch (ArgumentException ex)
{
    Console.WriteLine($"Error: {ex.Message}");
}
Console.WriteLine();

product.ChangePrice(2000);
product.DisplayData();