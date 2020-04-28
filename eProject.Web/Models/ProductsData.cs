using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace eProject.Web.Models
{
    public class ProductsData
    {
        [Display(Name = "Product name")]
        [StringLength(50, ErrorMessage = "Product name cannot be longer than 50 characters.")]
        public string Name { get; set; }

        [Display(Name = "Product description")]
        public string Description { get; set; }

        [Display(Name = "Repeat Password")]
        public decimal Price { get; set; }
    }
}