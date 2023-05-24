using System;
using System.ComponentModel.DataAnnotations;

namespace Tms.MysticShop.Model.Abtract
{
    public abstract class Audittable : IAudittable
    {
        public DateTime CreatedDate { get; set; }

        [MaxLength(300)]
        public string CreatedBy { get; set; }

    }
}