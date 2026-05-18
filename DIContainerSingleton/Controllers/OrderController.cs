using DIContainerSingleton.Logger;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DIContainerSingleton.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private readonly ILoggerService _loggerService;

        public OrderController(ILoggerService loggerService)
        {
            _loggerService = loggerService;
        }

        [HttpPost("create")]
        public IActionResult CreateOrder()
        {
            _loggerService.Log("Order creation started");

            // Simulate order logic
            var order = new Domain.Order
            {
                Id = 101,
                CustomerId = 1,
                Status = "Created"
            };

            _loggerService.Log($"Order #{order.Id} created successfully for customer {order.CustomerId}");

            return Ok(new
            {
                Message = "Order created successfully",
                OrderId = order.Id,
                LoggerInstanceId = _loggerService.InstanceId
            });
        }
    }
}