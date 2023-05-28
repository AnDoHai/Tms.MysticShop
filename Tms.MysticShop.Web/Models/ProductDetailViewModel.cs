using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using Tms.MysticShop.Model.Models;

namespace Tms.MysticShop.Web.Models
{
    public class ProductDetailViewModel
    {
        public int ProductDetailID { get; set; }
        public int ProductID { get; set; }
        public int ColorID { get; set; }
        public int SizeID { get; set; }

        public int Quantity { get; set; }

        public virtual ProductViewModel Product { get; set; }
        public virtual ColorViewModel Color { get; set; }
        public virtual SizeViewModel Size { get; set; }

        public virtual IEnumerable<ImageViewModel> Images { get; set; }

        public virtual IEnumerable<BillDetailViewModel> BillDetails { get; set; }
    }
}