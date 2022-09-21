using Vannon.Model.Entity;
using Vannon.Model.Interface.Repository;
using Vannon.Model.Interface.Service;

namespace Vannon.Business.Services
{
    public class UserService : BaseService<User>, IBaseService<User>, IUserService
    {
        public IUserRepository _userRepository;

        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }
        public User GetById(int id)
        {
            return _userRepository.GetById(id);
        }
    }
}
