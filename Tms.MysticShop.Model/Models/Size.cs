using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Tms.MysticShop.Model.Abtract;

namespace Tms.MysticShop.Model.Models
{
    [Table("Size")]
    public class Size : Audittable
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int SizeID { get; set; }
        [Required]
        public string SizeName { get; set; }

        public virtual IEnumerable<ProductDetail> ProductDetails { get; set; }
    }
}