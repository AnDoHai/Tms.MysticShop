using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tms.MysticShop.Data
{
    public class TmsMysticShopDbContext : DbContext
    {
        public TmsMysticShopDbContext() : base("")
        {

        }
    }
}
