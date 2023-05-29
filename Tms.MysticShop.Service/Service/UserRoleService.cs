using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tms.MysticShop.Data.Infrastructure;
using Tms.MysticShop.Data.Respositories;
using Tms.MysticShop.Model.Models;

namespace Tms.MysticShop.Service.Service
{
    public interface IUserRoleService
    {
        List<UserRole> GetAll();
    }
    public class UserRoleService : IUserRoleService
    {
        private IUserRoleRepository _userRoleRepository;
        private IUnitOfWork _unitOfWork;
        public UserRoleService(IUserRoleRepository userRoleRepository, IUnitOfWork unitOfWork)
        {
            this._userRoleRepository = userRoleRepository;
            this._unitOfWork = unitOfWork;
        }

        public List<UserRole> GetAll()
        {
            return _userRoleRepository.GetAll();
        }
    }
}
