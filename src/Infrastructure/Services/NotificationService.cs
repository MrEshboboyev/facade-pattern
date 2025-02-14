namespace Infrastructure.Services;

public class NotificationService
{
    public void SendOrderConfirmation(string email, int orderId)
    {
        Console.WriteLine($"📧 Order Confirmation sent to {email} for Order ID {orderId}.");
    }
}
