using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace OrderRabbify.Models
{
    public class ItemModel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ItemId { get; set; }
        [Required]
        public int ProductId { get; set; }
        [Required]
        public int OrderId { get; set; }
        [Required]
        public string ItemName { get; set; }
        [Required]
        public decimal ItemPricePaid { get; set; }
        [Required]
        public int ItemQuantity { get; set; }
        public OrderModel Order { get; set; }






    }
}
