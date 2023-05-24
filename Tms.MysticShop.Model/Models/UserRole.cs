using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Tms.MysticShop.Model.Abtract;

namespace Tms.MysticShop.Model.Models
{
    [Table("UserRole")]
    public class UserRole : Audittable
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int UserRoleID { get; set; }

        [Required]
        public string UserRoleName { get; set; }


        public virtual IEnumerable<User> Users { get; set;}
    }
}