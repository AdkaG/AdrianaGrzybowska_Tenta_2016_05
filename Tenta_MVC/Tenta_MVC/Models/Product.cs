using System.ComponentModel.DataAnnotations;
using Tenta_MVC.Attributes;

namespace Tenta_MVC_Adriana.Models
{
    public class Product
    {
        public int ProductId { get; set; }

        [Required, MinLength(2), MaxLength(100)]
        public string Name { get; set; }

        [MaxLength(500)]
        public string ProductText { get; set; }

        [Required, MaxLength(20), CheckProductNumber]
        public string ProductNumber { get; set; }

        [Required, Range(0.1, 1000000.0)]
        public double Price { get; set; }

        [Required, Range(0,1000)]
        public int ProductsInStock { get; set; }

        public virtual Store Store { get; set; }
    }
}