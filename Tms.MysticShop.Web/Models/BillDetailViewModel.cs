using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using Tms.MysticShop.Model.Models;

namespace Tms.MysticShop.Web.Models
{
    public class BillDetailViewModel
    {
        public int BillDetailID { get; set; }
        public int BillID { get; set; }
        public int Quanlity { get; set; }
        public float Total { get; set; }
        public int ProductDetailID { get; set; }

        public virtual ProductDetailViewModel ProductDetail { get; set; }
        public virtual BillViewModel Bill { get; set; }
    }
}