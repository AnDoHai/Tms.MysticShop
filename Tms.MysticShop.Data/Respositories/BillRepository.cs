using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tms.MysticShop.Data.Infrastructure;
using Tms.MysticShop.Model.Models;

namespace Tms.MysticShop.Data.Respositories
{
    public interface IBillRepository : IRepository<Bill>
    {
        IEnumerable<Bill> GetByAlias(string alias);
    }
    public class BillRepository : RepositoryBase<Bill>, IBillRepository
    {
        public BillRepository(DbFactory dbFactory) 
            : base(dbFactory)
        {

        }

        public IEnumerable<Bill> GetByAlias(string alias)
        {
            return this.DbContext.Bills.Where(c => c.BillName == alias);
        }
    }
}
