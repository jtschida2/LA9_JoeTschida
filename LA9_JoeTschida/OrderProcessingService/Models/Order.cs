using LA9_JoeTschida.ProductService.Models;

namespace LA9_JoeTschida.OrderProcessingService.Models
{
    public class Order
    {
        public int OrderId { get; set; }
        public DateTime OrderDate { get; set; }
        public string CustomerName { get; set; }
        public List<Product> Products { get; set; }
    }

}
