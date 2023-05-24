using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tms.MysticShop.Model.Abtract;

namespace Tms.MysticShop.Model.Models
{
    [Table("BillDetail")]
    public class BillDetail : Audittable
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int BillDetailID { get; set; }
        [Required]
        public int BillID { get; set; }
        [Required]
        public int Quanlity { get; set; }
        [Required]
        public float Total { get; set; }
        [Required]
        public int ProductDetailID { get; set; }

        [ForeignKey("ProductDetailID")]
        public virtual ProductDetail ProductDetail { get; set; }
        [ForeignKey("BillID")]
        public virtual Bill Bill { get; set; }

    }
}
