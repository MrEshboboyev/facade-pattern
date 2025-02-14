namespace Infrastructure.Services;

public class ShippingService
{
    public void ShipOrder(int orderId, string product)
    {
        Console.WriteLine($"🚚 Order {orderId} for {product} has been shipped.");
    }
}
