﻿using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [DisplayName("Order")]
        [Range(1,100,ErrorMessage="Order must be between 1 and 100 only!!")]
        public int Order { get; set; }

        public DateTime CreatedDateTime { get; set; } = DateTime.Now;
    }
}
