using System.ComponentModel.DataAnnotations;
namespace WebApplication1.Models
{
    public class Items
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public double Price { get; set; }
        public DateTime CreatedDateTime { get; set; } = DateTime.Now;

        public int ItemCategoryId { get; set; }
        public ItemCategory ItemCategory  { get; set; }
    }
}
