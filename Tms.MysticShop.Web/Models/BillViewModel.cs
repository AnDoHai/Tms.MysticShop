using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using Tms.MysticShop.Model.Models;

namespace Tms.MysticShop.Web.Models
{
    public class BillViewModel
    {
        public int BillID { get; set; }
        public string BillName { get; set; }
        public int UserID { get; set; }
        public float Total { get; set; }
        public virtual IEnumerable<BillDetailViewModel> BillDetails { get; set; }
    }
}