using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using Tms.MysticShop.Model.Models;

namespace Tms.MysticShop.Web.Models
{
    public class ProductViewModel
    {
        public int ProductID { get; set; }
        public int CategoryID { get; set; }
        public string ProductName { get; set; }
        public string Description { get; set; }
        public float Price { get; set; }

        public virtual CategoryViewModel Category { get; set; }

        public virtual IEnumerable<ProductDetailViewModel> ProductDetails { get; set; }
    }
}