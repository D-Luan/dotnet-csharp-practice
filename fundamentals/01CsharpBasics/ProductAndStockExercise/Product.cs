namespace ProductAndStockExercise;

public class Product
{
    public string Name { get; private set; } = string.Empty;
    public decimal Price { get; private set; }
    public int QuantityInStock { get; private set; }

    public Product(string name, decimal price, int quantityInStock)
    {
        if (string.IsNullOrWhiteSpace(name)) throw new ArgumentException("Name cannot be empty");

        if (price <= 0) throw new ArgumentException("Price cannot be less or equal than 0");

        if (quantityInStock < 0) throw new ArgumentException("Quantity in Stock cannot be negative");

        Name = name;
        Price = price;
        QuantityInStock = quantityInStock;
    }

    public void AddStock(int quantity)
    {
        if (quantity <= 0) throw new ArgumentException("Quantity must be greater than 0");
        QuantityInStock += quantity;
    }

    public void RemoveStock(int quantity)
    {
        if (quantity <= 0) throw new ArgumentException("Quantity must be greater than 0");

        if (quantity > QuantityInStock) throw new ArgumentException("Quantity cannot be greater than stock");

        QuantityInStock -= quantity;
    }

    public decimal GetTotalValueInStock() => Price * QuantityInStock;

    public bool IsAvailable() => QuantityInStock > 0;

    public void ChangePrice(decimal newPrice)
    {
        if (newPrice <= 0) throw new ArgumentException("New price must be greater than 0");
        Price = newPrice;
    }

    public void DisplayData()
    {
        Console.WriteLine($"Product: {Name}");
        Console.WriteLine($"Price: R$ {Price:F2}");
        Console.WriteLine($"Quantity in stock: {QuantityInStock}");
        Console.WriteLine($"Available: {(IsAvailable() ? "Yes" : "No")}");
        Console.WriteLine($"Total value in stock: R$ {GetTotalValueInStock():F2}");
    }
}
