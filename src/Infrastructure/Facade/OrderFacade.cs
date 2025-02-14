using Domain.Models;
using Infrastructure.Services;

namespace ECommerce.Infrastructure.Facade;

public class OrderFacade
{
    private readonly PaymentService _paymentService;
    private readonly InventoryService _inventoryService;
    private readonly ShippingService _shippingService;
    private readonly NotificationService _notificationService;

    public OrderFacade()
    {
        _paymentService = new PaymentService();
        _inventoryService = new InventoryService();
        _shippingService = new ShippingService();
        _notificationService = new NotificationService();
    }

    public bool PlaceOrder(Order order)
    {
        Console.WriteLine($"🔹 Processing Order {order.OrderId} for {order.Product}...");

        // Check stock availability
        if (!_inventoryService.CheckStock(order.Product))
        {
            Console.WriteLine("❌ Order failed: Product out of stock.");
            return false;
        }

        // Process Payment
        if (!_paymentService.ProcessPayment(order.Amount))
        {
            Console.WriteLine("❌ Order failed: Payment unsuccessful.");
            return false;
        }

        // Reduce stock
        _inventoryService.ReduceStock(order.Product);

        // Ship the product
        _shippingService.ShipOrder(order.OrderId, order.Product);

        // Send order confirmation
        _notificationService.SendOrderConfirmation(order.CustomerEmail, order.OrderId);

        Console.WriteLine("✅ Order placed successfully!");
        return true;
    }
}
