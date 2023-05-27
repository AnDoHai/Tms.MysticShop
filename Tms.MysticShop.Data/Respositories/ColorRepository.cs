using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tms.MysticShop.Data.Infrastructure;
using Tms.MysticShop.Model.Models;

namespace Tms.MysticShop.Data.Respositories
{
    public interface IColorRepository : IRepository<Color>
    {

    }
    public class ColorRepository : RepositoryBase<Color>, IColorRepository
    {
        public ColorRepository(DbFactory dbFactory)
           : base(dbFactory)
        {

        }
    }
}
