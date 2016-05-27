using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Tenta_MVC_Adriana.Models
{
    public class Store
    {
        public int StoreId { get; set; }

        [Required, MinLength(1), MaxLength(100)]
        public string Name { get; set; }

        [Required, MaxLength(50)]
        public string Address { get; set; }

        public virtual List<Product> Products { get; set; }
    }
}