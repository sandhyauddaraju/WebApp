using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models
{
  public class Order
    {
        [Key]
        public int OrderId { get; set; }

        //[Required]
        //public int ItemCategoryId { get; set; }
        //public ItemCategory ItemCategory { get; set; }


        [DisplayName("Order Identifier")]
        public string OrderIdentifier { get; set; }
        public int ItemsId { get; set; }
        public Items Items { get; set; }

        public int Quantity { get; set; }
        public DateTime CreatedDateTime { get; set; } = DateTime.Now;

    }
}
