namespace Infrastructure.Services;

public class PaymentService
{
    public bool ProcessPayment(decimal amount)
    {
        Console.WriteLine($"💳 Payment of ${amount} processed successfully.");
        return true;
    }
}
