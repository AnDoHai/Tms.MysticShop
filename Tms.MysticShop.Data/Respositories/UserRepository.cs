using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tms.MysticShop.Data.Infrastructure;
using Tms.MysticShop.Model.Models;

namespace Tms.MysticShop.Data.Respositories
{
    public interface IUserRepository : IRepository<User>
    {

    }
    public class UserRepository : RepositoryBase<User>, IUserRepository
    {
        public UserRepository(DbFactory dbFactory)
           : base(dbFactory)
        {

        }
    }
}
