using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using OrderRabbify.Enums;

namespace OrderRabbify.Models
{
    public class OrderModel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int OrderId { get; set; }

        public List<ItemModel> Items { get; set; }

        [Required]
        public OrderStatus Status { get; set; } = OrderStatus.Ativo;
    }
}
