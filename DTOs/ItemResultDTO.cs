using OrderRabbify.Models;

namespace OrderRabbify.DTOs
{
    public class ItemResultDTO
    {
        public IEnumerable<ItemModel> Items { get; set; }
    }
}
