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
    [Table("Bill")]
    public class Bill : Audittable
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int BillID { get; set; }
        [Required]
        public string BillName { get; set;}
        [Required]
        public int UserID { get; set; }
        [Required]
        public float Total { get; set; }
        public virtual IEnumerable<BillDetail> BillDetails { get; set; }
    }
}
