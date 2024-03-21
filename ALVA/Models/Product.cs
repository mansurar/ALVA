using System;
using System.ComponentModel.DataAnnotations;

namespace ALVA.Models
{
    public class Product
    {
        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        [DataType(DataType.Currency)]
        public decimal Price { get; set; }

        [Required]
        [StringLength(1024)]
        public string Description { get; set; }

        public string Category { get; set; }

        public string ImageUrl { get; set; }
    }
}