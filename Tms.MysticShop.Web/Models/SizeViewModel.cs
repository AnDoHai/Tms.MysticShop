using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using Tms.MysticShop.Model.Models;

namespace Tms.MysticShop.Web.Models
{
    public class SizeViewModel
    {
        public int SizeID { get; set; }
        public string SizeName { get; set; }

        public virtual IEnumerable<ProductDetailViewModel> ProductDetails { get; set; }
    }
}