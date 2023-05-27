using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tms.MysticShop.Data.Infrastructure;
using Tms.MysticShop.Model.Models;

namespace Tms.MysticShop.Data.Respositories
{
    public interface ISizeRepository : IRepository<Size>
    {

    }
    public class SizeRepository : RepositoryBase<Size>, ISizeRepository
    {
        public SizeRepository(DbFactory dbFactory)
           : base(dbFactory)
        {

        }
    }
}
