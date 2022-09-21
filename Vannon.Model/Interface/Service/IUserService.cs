using Vannon.Model.Entity;

namespace Vannon.Model.Interface.Service
{
    public interface IUserService : IBaseService<User>
    {
        User GetById(int id);
    }
}
