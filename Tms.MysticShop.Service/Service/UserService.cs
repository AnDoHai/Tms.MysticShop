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
    public interface IUserService
    {
        List<User> GetAll();
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

        public List<User> GetAll()
        {
            try
            {
                var users = _userRepository.GetAll(new string[]{ "UserRole"});

                if (users.Any() && users.Count() > 0)
                {
                    return users.ToList();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            return null;
        }
    }
}
