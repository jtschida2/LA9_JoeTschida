using LA9_JoeTschida.OrderProcessingService.Models;
using LA9_JoeTschida.ProductService.Models;
using Microsoft.AspNetCore.Mvc;

namespace LA9_JoeTschida.Controllers
{
    [ApiController]
    [Route("api/orders")]
    public class OrdersController : ControllerBase
    {
        private static List<Order> orders = new List<Order>
    {
        new Order
        {
            OrderId = 1,
            OrderDate = DateTime.Now,
            CustomerName = "John Doe",
            Products = new List<Product>
            {
                new Product { ProductId = 1, ProductName = "Laptop", Price = 1200.99m }
            }
        }
    };

        [HttpGet]
        public ActionResult<IEnumerable<Order>> GetOrders()
        {
            return Ok(orders);
        }

        [HttpGet("{id}")]
        public ActionResult<Order> GetOrder(int id)
        {
            var order = orders.FirstOrDefault(o => o.OrderId == id);
            if (order == null)
                return NotFound();

            return Ok(order);
        }
    }

}
