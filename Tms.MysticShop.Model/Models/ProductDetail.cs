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
    [Table("ProductDetail")]
    public class ProductDetail : Audittable
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ProductDetailID { get; set; }
        [Required] 
        public int ProductID { get; set; }
        [Required]
        public int ColorID { get; set; }
        [Required]
        public int SizeID { get; set; }

        //so luong
        [Required]
        public int Quantity { get; set; }


        [ForeignKey("ProductID")]
        public virtual Product Product { get; set; }
        [ForeignKey("ColorID")]
        public virtual Color Color { get; set; }
        [ForeignKey("SizeID")]
        public virtual Size Size { get; set; }

        public virtual IEnumerable<Image> Images { get; set; }

        public virtual IEnumerable<BillDetail> BillDetails { get; set; }



    }
}
