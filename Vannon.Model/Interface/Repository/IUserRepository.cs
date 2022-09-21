using Vannon.Model.Entity;

namespace Vannon.Model.Interface.Repository
{
    public interface IUserRepository : IBaseRepository<User>
    {
        User GetById(int id);
    }
}
