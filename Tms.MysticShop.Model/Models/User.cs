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
    [Table("User")]
    public class User : Audittable
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int UserID { get; set; }
        [Required]
        public string UserName { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string PhoneNumber { get; set; }
        [Required]
        public string Address { get; set; }
        [Required]
        public string Password { get; set; }
        [Required]
        public int UserRoleID { get; set; }


        [ForeignKey("UserRoleID")]
        public virtual UserRole UserRole { get; set; }
    }
}
