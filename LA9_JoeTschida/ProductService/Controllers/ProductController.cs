using LA9_JoeTschida.ProductService.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LA9_JoeTschida.ProductService.Controllers
{
    [ApiController]
    [Route("api/products")]
    public class ProductController : ControllerBase
    {
        private static List<Product> products = new List<Product>
    {
        new Product { ProductId = 1, ProductName = "Laptop", Price = 1200.99m },
        new Product { ProductId = 2, ProductName = "Smartphone", Price = 899.99m }
    };

        [HttpGet]
        public ActionResult<IEnumerable<Product>> GetProducts()
        {
            return Ok(products);
        }

        [HttpGet("{id}")]
        public ActionResult<Product> GetProduct(int id)
        {
            var product = products.FirstOrDefault(p => p.ProductId == id);
            if (product == null)
                return NotFound();

            return Ok(product);
        }
    }
}

