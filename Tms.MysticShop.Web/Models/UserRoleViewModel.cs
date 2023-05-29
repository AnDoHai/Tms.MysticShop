using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using Tms.MysticShop.Model.Models;

namespace Tms.MysticShop.Web.Models
{
    public class UserRoleViewModel
    {
        public int UserRoleID { get; set; }
        public string UserRoleName { get; set; }

        public DateTime CreatedDate { get; set; }
        public string CreatedBy { get; set; }

        public virtual IEnumerable<UserViewModel> Users { get; set; }
    }
}