using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tms.MysticShop.Model.Models;

namespace Tms.MysticShop.Data
{
    public class TmsMysticShopDbContext : DbContext
    {
        public TmsMysticShopDbContext() : base("TmsMysticShopConnection") { 
            this.Configuration.LazyLoadingEnabled = false;
        } 
        
        public DbSet<Bill> Bills { get; set; }

        public DbSet<BillDetail> BillDetails { get; set; }
        public DbSet<Category> Categorys { get; set; }
        public DbSet<Color> Colors { get; set; }
        public DbSet<Image> Images { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductDetail> ProductDetails { get; set; }
        public DbSet<Size> Sizes { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<UserRole> UserRoles { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
           
        }
    }
}
