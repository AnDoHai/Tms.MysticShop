using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tms.MysticShop.Data.Infrastructure;
using Tms.MysticShop.Model.Models;

namespace Tms.MysticShop.Data.Respositories
{
    public interface IProductDetailRepository : IRepository<ProductDetail>
    {

    }
    public class ProductDetailRepository : RepositoryBase<ProductDetail>, IProductDetailRepository
    {
        public ProductDetailRepository(DbFactory dbFactory)
           : base(dbFactory)
        {

        }
    }
}
