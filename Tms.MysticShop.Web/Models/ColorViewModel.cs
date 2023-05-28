using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using Tms.MysticShop.Model.Models;

namespace Tms.MysticShop.Web.Models
{
    public class ColorViewModel
    {
        public int ColorID { get; set; }
        public string ColorName { get; set; }

        public virtual IEnumerable<ProductDetailViewModel> ProductDetails { get; set; }
    }
}