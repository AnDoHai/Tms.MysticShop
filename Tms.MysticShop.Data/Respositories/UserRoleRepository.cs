using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tms.MysticShop.Data.Infrastructure;
using Tms.MysticShop.Model.Models;

namespace Tms.MysticShop.Data.Respositories
{
    public interface IUserRoleRepository : IRepository<UserRole>
    {
        List<UserRole> GetAll();
    }
    public class UserRoleRepository : RepositoryBase<UserRole>, IUserRoleRepository
    {
        public UserRoleRepository(IDbFactory dbFactory)
           : base(dbFactory)
        {

        }

        public List<UserRole> GetAll()
        {
            var dbContext = DbContext.UserRoles;
            if (dbContext.Count() > 0)
            {
                return dbContext.ToList();
            }
            return null;
        }
    }
}
