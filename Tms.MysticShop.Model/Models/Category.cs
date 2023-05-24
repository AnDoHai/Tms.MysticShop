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
    [Table("Category")]
    public class Category : Audittable
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CategoryID { get; set; }
        [Required]
        public string CategoryName { get; set; }


        public virtual ICollection<Product> Products { get; set; }

    }
}
