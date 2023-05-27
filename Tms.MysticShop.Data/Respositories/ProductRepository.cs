using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tms.MysticShop.Data.Infrastructure;
using Tms.MysticShop.Model.Models;

namespace Tms.MysticShop.Data.Respositories
{
    public interface IProductRepository : IRepository<Product>
    {

    }
    public class ProductRepository : RepositoryBase<Product>, IProductRepository
    {
        public ProductRepository(DbFactory dbFactory)
           : base(dbFactory)
        {

        }
    }
}
