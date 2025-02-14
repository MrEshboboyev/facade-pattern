namespace Infrastructure.Services;

public class InventoryService
{
    public bool CheckStock(string product)
    {
        Console.WriteLine($"📦 Checking stock for {product}...");
        return true; // Assume product is in stock.
    }

    public void ReduceStock(string product)
    {
        Console.WriteLine($"✅ Stock for {product} reduced.");
    }
}