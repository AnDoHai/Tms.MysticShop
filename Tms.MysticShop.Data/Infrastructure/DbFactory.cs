using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tms.MysticShop.Data.Infrastructure
{
    public class DbFactory : Disposeable, IDbFactory
    {
        private TmsMysticShopDbContext dbContext;
        public TmsMysticShopDbContext Init()
        {
            return dbContext ?? (dbContext = new TmsMysticShopDbContext());
        }

        protected override void DisposeCore()
        {
            if (dbContext != null)
            {
                dbContext.Dispose();
            }
        }


    }
}
