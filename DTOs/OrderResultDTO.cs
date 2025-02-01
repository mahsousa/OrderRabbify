using OrderRabbify.Models;

namespace OrderRabbify.DTOs
{
    public class OrderResultDTO
    {
        public IEnumerable<OrderModel> Orders { get; set; }
    }
}
