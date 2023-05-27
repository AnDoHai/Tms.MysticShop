using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tms.MysticShop.Data.Infrastructure
{
    public class InitOfWork : IUnitOfWork
    {
        private readonly IDbFactory dbFactory;
        private TmsMysticShopDbContext dbContext;

        public InitOfWork(IDbFactory dbFactory)
        {
            this.dbFactory = dbFactory;
        }
        public TmsMysticShopDbContext DbContext
        {
            get { return dbContext??(dbContext = dbFactory.Init()); } 
        }
        public void Commit()
        {
            DbContext.SaveChanges();
        }
    }
}
