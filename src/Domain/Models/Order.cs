namespace Domain.Models;

public class Order(int orderId, string customerEmail, string product, decimal amount)
{
    public int OrderId { get; set; } = orderId;
    public string CustomerEmail { get; set; } = customerEmail;
    public string Product { get; set; } = product;
    public decimal Amount { get; set; } = amount;
}
