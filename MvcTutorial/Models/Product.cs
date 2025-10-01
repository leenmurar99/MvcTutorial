
using System.ComponentModel.DataAnnotations;

namespace MvcTutorial.Models
{
    public class Product
    {
        public int id { get; set; }

        [Required]
        [StringLength(100)]
        public string? Name { get; set; }

        [Range(1, 10000)]
        public decimal Price { get; set; }
        
        [Display(Name ="Stock Quantity")]
        public int Stock { get; set; }
    }
}