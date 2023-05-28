using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using Tms.MysticShop.Model.Models;

namespace Tms.MysticShop.Web.Models
{
    public class ImageViewModel
    {
        public int ImageID { get; set; }
        public string ImageLink { get; set; }
        public int ProductDetailID { get; set; }
        public virtual ProductDetailViewModel ProductDetail { get; set; }
    }
}