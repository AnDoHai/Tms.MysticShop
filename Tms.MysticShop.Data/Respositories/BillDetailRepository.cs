using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tms.MysticShop.Data.Infrastructure;
using Tms.MysticShop.Model.Models;

namespace Tms.MysticShop.Data.Respositories
{
    public interface IBillDetailRepository : IRepository<BillDetail>
    {
        
    }

    public class BillDetailRepository : RepositoryBase<BillDetail>, IBillDetailRepository
    {
        public BillDetailRepository(DbFactory dbFactory)
            : base(dbFactory)
        {

        }
    }
}
