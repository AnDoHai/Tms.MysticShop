using System;

namespace Tms.MysticShop.Model.Abtract
{
    public interface IAudittable
    {
        DateTime CreatedDate { get; set; }
        string CreatedBy { get; set; }
    }
}