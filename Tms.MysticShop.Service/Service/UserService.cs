using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tms.MysticShop.Data.Infrastructure;
using Tms.MysticShop.Data.Respositories;

namespace Tms.MysticShop.Service.Service
{
    public interface IUserService
    {

    }
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;
        private readonly IUnitOfWork _unitOfWork;

        public UserService(IUserRepository userRepository, IUnitOfWork unitOfWork)
        {
            this._userRepository = userRepository;
            this._unitOfWork = unitOfWork;
        }
    }
}
