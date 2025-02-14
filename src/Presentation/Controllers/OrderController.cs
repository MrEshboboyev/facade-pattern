using Microsoft.AspNetCore.Mvc;
using ECommerce.Infrastructure.Facade;
using Domain.Models;

namespace Presentation.Controllers;

[Route("api/[controller]")]
[ApiController]
public class OrderController : ControllerBase
{
    private readonly OrderFacade _orderFacade;

    public OrderController() => _orderFacade = new OrderFacade();

    [HttpPost("place")]
    public IActionResult PlaceOrder([FromBody] Order order)
    {
        bool success = _orderFacade.PlaceOrder(order);
        return success ? Ok("Order placed successfully.") : BadRequest("Order failed.");
    }
}